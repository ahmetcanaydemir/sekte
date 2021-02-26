import numpy as np
import pickle
import librosa
import sounddevice as sd
import tensorflow as tf
from pathlib import Path

'''Ters Kısa zamanlı Fourier dönüşümü yapar'''


def ters_stft_donusumu(stft_ozellikleri, pencere_uzunlugu, overlap):
    return librosa.istft(stft_ozellikleri, win_length=pencere_uzunlugu, hop_length=overlap)


def ozellikleri_sese_geri_donustur(ozellikler, evre, pencere_uzunlugu, overlap, temizOrtalama=None, temizStd=None):
    # çıkışı orijinal aralığa geri ölçeklendirir
    if temizOrtalama and temizStd:
        ozellikler = temizStd * ozellikler + temizOrtalama

    evre = np.transpose(evre, (1, 0))
    ozellikler = np.squeeze(ozellikler)
    # Daha önce yapılan abs() işlemini düzeltir
    ozellikler = ozellikler * np.exp(1j * evre)

    ozellikler = np.transpose(ozellikler, (1, 0))
    return ters_stft_donusumu(ozellikler, pencere_uzunlugu=pencere_uzunlugu, overlap=overlap)


def oynat(ses, ornekleme_orani):
    # ipd.display(ipd.ses(data=ses, rate=ornekleme_orani))  # Wav dosyası
    sd.play(ses, ornekleme_orani, blocking=True)


def temiz_sese_gurultu_ekle(temiz_ses, gurultu_sinyali):
    if len(temiz_ses) >= len(gurultu_sinyali):
        # print("Gürültülü sinyal, temiz ses girişinden daha küçük. Gürültü çoğaltılıyor.")
        while len(temiz_ses) >= len(gurultu_sinyali):
            gurultu_sinyali = np.append(gurultu_sinyali, gurultu_sinyali)

    # Gürültü dosyasındaki rastgele bir konumdan gürültü parçası alınıyor
    ind = np.random.randint(0, gurultu_sinyali.size - temiz_ses.size)

    gurultuParcasi = gurultu_sinyali[ind: ind + temiz_ses.size]

    konusma_kuvveti = np.sum(temiz_ses ** 2)
    gurultu_kuvveti = np.sum(gurultuParcasi ** 2)
    gurultuluSes = temiz_ses + \
        np.sqrt(konusma_kuvveti / gurultu_kuvveti) * gurultuParcasi
    return gurultuluSes


def sesi_oku(dosyayolu, ornekleme_orani, normallestir=True):
    ses, sr = librosa.load(str(Path(dosyayolu)), sr=ornekleme_orani)
    if normallestir is True:
        div_fac = 1 / np.max(np.abs(ses)) / 3.0
        ses = ses * div_fac
        # ses = librosa.util.normalize(ses)
    return ses, sr


def girdi_ozelliklerini_hazirla(stft_ozellikleri, parcaSayisi, ozellikSayisi):
    gurultuluSTFT = np.concatenate(
        [stft_ozellikleri[:, 0:parcaSayisi - 1], stft_ozellikleri], axis=1)
    stftParcalari = np.zeros(
        (ozellikSayisi, parcaSayisi, gurultuluSTFT.shape[1] - parcaSayisi + 1))

    for index in range(gurultuluSTFT.shape[1] - parcaSayisi + 1):
        stftParcalari[:, :, index] = gurultuluSTFT[:,
                                                   index:index + parcaSayisi]
    return stftParcalari


def girdi_ozelliklerini_getir(belirleyiciListesi):
    belirleyiciler = []
    for gurultulu_stft_byklk_ozellikleri in belirleyiciListesi:
        # CNN için, giriş özelliği arka arkaya 8 gürültülü
        # STFT büyüklüğü vektörleri: 129 × 8,
        girdiOzellikleri = girdi_ozelliklerini_hazirla(
            gurultulu_stft_byklk_ozellikleri)
        belirleyiciler.append(girdiOzellikleri)

    return belirleyiciler


def _bytes_ozellik(value):
    """string veya bayttan bytes_list döndürür."""
    if isinstance(value, type(tf.constant(0))):
        # BytesList won't unpack a string from an EagerTensor.
        value = value.numpy()
    return tf.train.Feature(bytes_list=tf.train.BytesList(value=[value]))


def _float_ozellik(value):
    """float / doubledan float_list döndürür."""
    return tf.train.Feature(float_list=tf.train.FloatList(value=[value]))


def _int64_ozellik(value):
    """bool / enum / int / uint'den int64_list döndürür."""
    return tf.train.Feature(int64_list=tf.train.Int64List(value=[value]))


def tf_ozellik_getir(gurultulu_stft_byklk_ozellikleri, temiz_stft_buyuklugu, gurultu_stft_asamasi):
    gurultulu_stft_byklk_ozellikleri = gurultulu_stft_byklk_ozellikleri.astype(
        np.float32).tostring()
    temiz_stft_buyuklugu = temiz_stft_buyuklugu.astype(np.float32).tostring()
    gurultu_stft_asamasi = gurultu_stft_asamasi.astype(np.float32).tostring()

    ornek = tf.train.Example(features=tf.train.Features(feature={
        'gurultu_stft_asamasi': _bytes_ozellik(gurultu_stft_asamasi),
        'gurultulu_stft_byklk_ozellikleri': _bytes_ozellik(gurultulu_stft_byklk_ozellikleri),
        'temiz_stft_buyuklugu': _bytes_ozellik(temiz_stft_buyuklugu)}))
    return ornek
