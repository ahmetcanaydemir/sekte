import pandas as pd
import numpy as np
import os

np.random.seed(999)


class MozillaVoiceDataset:

    def __init__(self, temelyol, *, val_dataset_boyutu):
        self.temelyol = temelyol
        self.val_dataset_boyutu = val_dataset_boyutu

    def mozilla_voice_dosyaadlari_getir(self, dataframe_adi='train.tsv'):
        mozilla_metadata = pd.read_csv(os.path.join(
            self.temelyol, dataframe_adi), sep='\t')
        temiz_dosyalar = mozilla_metadata['path'].values
        np.random.shuffle(temiz_dosyalar)
        print("Toplam eğitilecek dosya sayısı:", len(temiz_dosyalar))
        return temiz_dosyalar

    def train_val_dosyaadlari_getir(self):
        temiz_dosyalar = self.mozilla_voice_dosyaadlari_getir(
            dataframe_adi='train.tsv')

        temiz_dosyalar = [os.path.join(
            self.temelyol, 'clips', dosyaadi) for dosyaadi in temiz_dosyalar]

        temiz_dosyalar = temiz_dosyalar[:-self.val_dataset_boyutu]
        clean_val_files = temiz_dosyalar[-self.val_dataset_boyutu:]
        print("# Eğitim için temiz dosya sayısı:", len(temiz_dosyalar))
        print("# Doğrulama için temiz dosya sayısı:", len(clean_val_files))
        return temiz_dosyalar, clean_val_files

    def test_dosyaadlarini_getir(self):
        temiz_dosyalar = self.mozilla_voice_dosyaadlari_getir(
            dataframe_adi='test.tsv')

        temiz_dosyalar = [os.path.join(
            self.temelyol, 'clips', dosyaadi) for dosyaadi in temiz_dosyalar]

        print("# Test için temiz dosya sayısı:", len(temiz_dosyalar))
        return temiz_dosyalar
