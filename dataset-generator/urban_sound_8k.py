import pandas as pd
import numpy as np
import os

np.random.seed(999)


class UrbanSound8K:
    def __init__(self, temelyol, *, val_dataset_boyutu, sinifIdleri=None):
        self.temelyol = temelyol
        self.val_dataset_boyutu = val_dataset_boyutu
        self.sinifIdleri = sinifIdleri

    def _urban_sound_8K_dosyaadlarini_getir(self):
        urbansound_metadata = pd.read_csv(os.path.join(
            self.temelyol, 'metadata', 'UrbanSound8K.csv'))

        # karıştır
        urbansound_metadata.reindex(
            np.random.permutation(urbansound_metadata.index))

        return urbansound_metadata

    def sinifId_ile_dosyaadi_getir(self, metadata):

        if self.sinifIdleri is None:
            self.sinifIdleri = np.unique(metadata['classID'].values)
            print("Sınıf numaraları:", self.sinifIdleri)

        tum_dosyalar = []
        dosya_sayaci = 0
        for c in self.sinifIdleri:
            sinif_basina_dosyalar = metadata[metadata['classID'] == c][[
                'slice_file_name', 'fold']].values
            sinif_basina_dosyalar = [os.path.join(self.temelyol, 'audio', 'fold' + str(dosya[1]), dosya[0]) for dosya in
                                     sinif_basina_dosyalar]
            print(str(c), ' isimli sınıfta', len(
                sinif_basina_dosyalar), 'dosya var')
            dosya_sayaci += len(sinif_basina_dosyalar)
            tum_dosyalar.extend(sinif_basina_dosyalar)

        assert len(tum_dosyalar) == dosya_sayaci
        return tum_dosyalar

    def train_val_dosyaadlarini_getir(self):
        urbansound_metadata = self._urban_sound_8K_dosyaadlarini_getir()

        # 0-9 arasındaki klasörleri kullanılacak
        urbansound_train = urbansound_metadata[urbansound_metadata.fold != 10]

        urbansound_train_dosyaadlari = self.sinifId_ile_dosyaadi_getir(
            urbansound_train)
        np.random.shuffle(urbansound_train_dosyaadlari)

        # train/validation için ayrı gürültü dosyaları
        urbansound_val = urbansound_train_dosyaadlari[-self.val_dataset_boyutu:]
        urbansound_train = urbansound_train_dosyaadlari[:-
                                                        self.val_dataset_boyutu]
        print("Eğitim gürültüsü:", len(urbansound_train))
        print("Doğrulama gürültüsü:", len(urbansound_val))

        return urbansound_train, urbansound_val

    def test_dosyaadlarini_getir(self):
        urbansound_metadata = self._urban_sound_8K_dosyaadlarini_getir()

        # 10. gürültü klasörü sadece test için kullanılacak
        urbansound_train = urbansound_metadata[urbansound_metadata.fold == 10]

        urbansound_test_dosyaadlari = self.sinifId_ile_dosyaadi_getir(
            urbansound_train)
        np.random.shuffle(urbansound_test_dosyaadlari)

        print("# gürültü test dosyaları sayısı:",
              len(urbansound_test_dosyaadlari))
        return urbansound_test_dosyaadlari
