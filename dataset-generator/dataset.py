import librosa
import numpy as np
import math
import multiprocessing
import os
import tensorflow as tf
from sklearn.preprocessing import StandardScaler

from ozellik_cikarici import OzellikCikarici
from util import girdi_ozelliklerini_hazirla, sesi_oku, tf_ozellik_getir

np.random.seed(999)
tf.random.set_seed(999)


class Dataset:
    def __init__(self, temiz_dosyaadlari, gurultulu_dosyaadlari, **ayar):
        self.temiz_dosyaadlari = temiz_dosyaadlari
        self.gurultulu_dosyaadlari = gurultulu_dosyaadlari
        self.ornekleme_orani = ayar['sr']
        self.overlap = ayar['overlap']
        self.window_length = ayar['pencereBuyuklugu']
        self.ses_maks_uzunluk = ayar['ses_maks_uzunluk']

    def _ornek_gurutlu_dosyaadi(self):
        return np.random.choice(self.gurultulu_dosyaadlari)

    def _sessiz_frameleri_sil(self, ses):
        kirpilmis_ses = []
        indeksler = librosa.effects.split(
            ses, hop_length=self.overlap, top_db=20)

        for index in indeksler:
            kirpilmis_ses.extend(ses[index[0]: index[1]])
        return np.array(kirpilmis_ses)

    def _faz_farki_olceklendirme(self, temiz_spektral_buyukluk, temiz_faz, gurultulu_faz):
        assert temiz_faz.shape == gurultulu_faz.shape, "Shape eşleşmeli."
        return temiz_spektral_buyukluk * np.cos(temiz_faz - gurultulu_faz)

    def gurultulu_sesi_getir(self, *, dosyaadi):
        return sesi_oku(dosyaadi, self.ornekleme_orani)

    def _sesi_rastgele_kirp(self, ses, sure):
        ses_sure_saniyeler = librosa.core.get_duration(
            ses, self.ornekleme_orani)

        # sure: kırpılan sesin saniye cinsinden uzunluğu
        if sure >= ses_sure_saniyeler:
            return ses

        ses_sure_ms = math.floor(
            ses_sure_saniyeler * self.ornekleme_orani)
        sure_ms = math.floor(sure * self.ornekleme_orani)
        idx = np.random.randint(0, ses_sure_ms - sure_ms)
        return ses[idx: idx + sure_ms]

    def _temiz_sese_gurultu_ekle(self, temiz_ses, gurultu_sinyali):
        if len(temiz_ses) >= len(gurultu_sinyali):
            # print("Gürültülü sinyal temiz ses girişinden daha küçük. Gürültü çoğaltılıyor.")
            while len(temiz_ses) >= len(gurultu_sinyali):
                gurultu_sinyali = np.append(gurultu_sinyali, gurultu_sinyali)

        # Gürültü parçası gürültü dosyasındaki rastgele bir konumdan elde ediliyor
        ind = np.random.randint(0, gurultu_sinyali.size - temiz_ses.size)

        gurultuParcasi = gurultu_sinyali[ind: ind + temiz_ses.size]

        konusma_kuvveti = np.sum(temiz_ses ** 2)
        gurultu_kuvveti = np.sum(gurultuParcasi ** 2)
        gurultuluses = temiz_ses + \
            np.sqrt(konusma_kuvveti / gurultu_kuvveti) * gurultuParcasi
        return gurultuluses

    def paralel_ses_isleme(self, temiz_dosyaadi):

        temiz_ses, _ = sesi_oku(temiz_dosyaadi, self.ornekleme_orani)

        # temiz sesten sessiz framleri yok et
        temiz_ses = self._sessiz_frameleri_sil(temiz_ses)

        gurultu_dosyaadi = self._ornek_gurutlu_dosyaadi()

        # gurultulu dosyaadını oku
        gurultulu_ses, sr = sesi_oku(gurultu_dosyaadi, self.ornekleme_orani)

        # gurultulu sesten sessiz framleri yok et
        gurultulu_ses = self._sessiz_frameleri_sil(gurultulu_ses)

        # sesin rastgele sabit boyutlu parçacıklarını al
        temiz_ses = self._sesi_rastgele_kirp(
            temiz_ses, sure=self.ses_maks_uzunluk)

        # temiz sese gurultu ekle
        gurultuGirdisi = self._temiz_sese_gurultu_ekle(
            temiz_ses, gurultulu_ses)

        # extract stft features from noisy ses
        gurultuGirdisiOzelligi = OzellikCikarici(gurultuGirdisi, pencereBuyuklugu=self.window_length, overlap=self.overlap,
                                                 ornekleme_orani=self.ornekleme_orani)
        gurultulu_spektogram = gurultuGirdisiOzelligi.stft_spektogrami_getir()

        # Veya faz açısını getir (radyan cinsinden)
        # noisy_stft_magnitude, noisy_stft_phase = librosa.magphase(noisy_stft_features)
        gurultulu_faz = np.angle(gurultulu_spektogram)

        # spektralın büyüklüğünü getir
        gurultu_buyuklugu = np.abs(gurultulu_spektogram)

        # temiz sesden stft özelliklerini getir
        temiz_ses_ozelligi = OzellikCikarici(temiz_ses, pencereBuyuklugu=self.window_length, overlap=self.overlap,
                                             ornekleme_orani=self.ornekleme_orani)
        temiz_spektogram = temiz_ses_ozelligi.stft_spektogrami_getir()
        # temiz_spektogram = cleansesFE.get_mel_spectrogram()

        # temiz faz açısını getir
        temiz_faz = np.angle(temiz_spektogram)

        # temiz spektralın büyüklüğünü getir
        temiz_buyukluk = np.abs(temiz_spektogram)
        # temiz_buyukluk = 2 * temiz_buyukluk / np.sum(scipy.signal.hamming(self.window_length, sym=False))

        temiz_buyukluk = self._faz_farki_olceklendirme(
            temiz_buyukluk, temiz_faz, gurultulu_faz)

        scaler = StandardScaler(copy=False, with_mean=True, with_std=True)
        gurultu_buyuklugu = scaler.fit_transform(gurultu_buyuklugu)
        temiz_buyukluk = scaler.transform(temiz_buyukluk)

        return gurultu_buyuklugu, temiz_buyukluk, gurultulu_faz

    def tf_kaydi_olustur(self, *, onek, altset_boyutu, paralel=True):
        sayac = 0
        p = multiprocessing.Pool(multiprocessing.cpu_count())

        for i in range(0, len(self.temiz_dosyaadlari), altset_boyutu):

            tfrecord_dosyaadi = 'D:\\PROJE\\records\\' + onek + \
                '_' + str(sayac) + '.tfrecords'

            if os.path.isfile(tfrecord_dosyaadi):
                print(f"Geçiliyor {tfrecord_dosyaadi}")
                sayac += 1
                continue

            yazici = tf.io.TFRecordWriter(tfrecord_dosyaadi)
            temiz_dosyaadlari_sublist = self.temiz_dosyaadlari[i:i + altset_boyutu]

            print(f"Dosyalar işleniyor: {i}'den' {i + altset_boyutu}'ye'")
            if paralel:
                out = p.map(self.paralel_ses_isleme,
                            temiz_dosyaadlari_sublist)
            else:
                out = [self.paralel_ses_isleme(
                    dosyaadi) for dosyaadi in temiz_dosyaadlari_sublist]

            for o in out:
                gurultu_stft_buyukluk = o[0]
                temiz_stft_buyukluk = o[1]
                gurultu_stft_faz = o[2]

                gurultu_stft_byklk_ozellikleri = girdi_ozelliklerini_hazirla(
                    gurultu_stft_buyukluk, parcaSayisi=8, ozellikSayisi=129)

                gurultu_stft_byklk_ozellikleri = np.transpose(
                    gurultu_stft_byklk_ozellikleri, (2, 0, 1))
                temiz_stft_buyukluk = np.transpose(
                    temiz_stft_buyukluk, (1, 0))
                gurultu_stft_faz = np.transpose(gurultu_stft_faz, (1, 0))

                gurultu_stft_byklk_ozellikleri = np.expand_dims(
                    gurultu_stft_byklk_ozellikleri, axis=3)
                temiz_stft_buyukluk = np.expand_dims(
                    temiz_stft_buyukluk, axis=2)

                for x_, y_, p_ in zip(gurultu_stft_byklk_ozellikleri, temiz_stft_buyukluk, gurultu_stft_faz):
                    y_ = np.expand_dims(y_, 2)
                    ornek = tf_ozellik_getir(x_, y_, p_)
                    yazici.write(ornek.SerializeToString())

            sayac += 1
            yazici.close()
