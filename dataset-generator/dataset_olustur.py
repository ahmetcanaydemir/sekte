from mozilla_voice import MozillaVoiceDataset
from urban_sound_8k import UrbanSound8K
from dataset import Dataset
import warnings
import multiprocessing


def start():
    warnings.filterwarnings(action='ignore')

    mozilla_anadizin = 'D:\\PROJE\\en'
    urbansound_anadizin = 'D:\\PROJE\\UrbanSound8K\\UrbanSound8K'

    mozilla = MozillaVoiceDataset(mozilla_anadizin, val_dataset_boyutu=1000)
    temiz_train_dosyaadlari, temiz_val_dosyaadlari = mozilla.train_val_dosyaadlari_getir()

    us8K = UrbanSound8K(urbansound_anadizin, val_dataset_boyutu=200)
    gurultulu_train_dosyaadlari, gurultulu_val_dosyaadlari = us8K.train_val_dosyaadlarini_getir()

    pencereBuyuklugu = 256
    ayar = {'pencereBuyuklugu': pencereBuyuklugu,
            'overlap': round(0.25 * pencereBuyuklugu),
            'sr': 16000,
            'ses_maks_uzunluk': 0.8}

    val_dataset = Dataset(temiz_val_dosyaadlari,
                          gurultulu_val_dosyaadlari, **ayar)
    val_dataset.tf_kaydi_olustur(onek='val', altset_boyutu=2000)

    train_dataset = Dataset(temiz_train_dosyaadlari,
                            gurultulu_train_dosyaadlari, **ayar)
    train_dataset.tf_kaydi_olustur(onek='train', altset_boyutu=4000)

    # Test Dataset oluştur
    temiz_test_dosyaadlari = mozilla.test_dosyaadlarini_getir()

    gurultulu_test_dosyaadlari = us8K.test_dosyaadlarini_getir()

    test_dataset = Dataset(temiz_test_dosyaadlari,
                           gurultulu_test_dosyaadlari, **ayar)
    test_dataset.tf_kaydi_olustur(onek='test', altset_boyutu=1000, paralel=False)


if __name__ == '__main__':
    multiprocessing.freeze_support()
    start()
