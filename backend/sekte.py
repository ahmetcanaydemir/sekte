from libsekte.ozellik_cikarici import OzellikCikarici
import librosa
import os
import numpy as np
import matplotlib.pyplot as plt
from io import BytesIO
import base64
import soundfile as sf
import tempfile

pencereBuyuklugu = 256
overlap = round(0.25 * pencereBuyuklugu)  # %75 overlop
ffTUzunlugu = pencereBuyuklugu
girdiSr = 48e3
sr = 16e3
ozellikSayisi = ffTUzunlugu // 2 + 1
segmentSayisi = 8


def sesi_oku(dosyayolu, ornekleme_orani, normallestir=True):
    ses, sr = librosa.load(dosyayolu, sr=ornekleme_orani)
    if normallestir:
        div_fac = 1 / np.max(np.abs(ses)) / 3.0
        ses = ses * div_fac
    return ses, sr


def prepare_input_features(stft_ozellikleri):
    gurultuluSTFT = np.concatenate(
        [stft_ozellikleri[:, 0:segmentSayisi - 1], stft_ozellikleri], axis=1)
    stftParcalari = np.zeros(
        (ozellikSayisi, segmentSayisi, gurultuluSTFT.shape[1] - segmentSayisi + 1))  # pylint: disable=E1136  # pylint/issues/3139

    for index in range(gurultuluSTFT.shape[1] - segmentSayisi + 1):  # pylint: disable=E1136  # pylint/issues/3139
        stftParcalari[:, :, index] = gurultuluSTFT[:,
                                                   index:index + segmentSayisi]
    return stftParcalari


def ozellikleri_sese_geri_donustur(gurultuluSesOzellikCikarici, ozellikler, faz, temizOrtalama=None, temizStd=None):
    if temizOrtalama and temizStd:
        ozellikler = temizStd * ozellikler + temizOrtalama

    faz = np.transpose(faz, (1, 0))
    ozellikler = np.squeeze(ozellikler)

    ozellikler = ozellikler * np.exp(1j * faz)

    ozellikler = np.transpose(ozellikler, (1, 0))
    return gurultuluSesOzellikCikarici.stft_spektogramindan_sesi_getir(ozellikler)


def Sekte(model, soundPath):
    gurultuEklenmisSes, sr = sesi_oku(
        soundPath, ornekleme_orani=16e3)
# ipd.Audio(data=gurultuEklenmisSes, rate=sr)  # Yerel Wav yükle
    gurultuluSesOzellikCikarici = OzellikCikarici(
        gurultuEklenmisSes, pencereBuyuklugu=pencereBuyuklugu, overlap=overlap, ornekleme_orani=sr)
    gurultu_stft_ozellikleri = gurultuluSesOzellikCikarici.stft_spektogrami_getir()

    gurultuluFaz = np.angle(gurultu_stft_ozellikleri)
    gurultu_stft_ozellikleri = np.abs(gurultu_stft_ozellikleri)

    mean = np.mean(gurultu_stft_ozellikleri)
    std = np.std(gurultu_stft_ozellikleri)
    gurultu_stft_ozellikleri = (gurultu_stft_ozellikleri - mean) / std

    predictors = prepare_input_features(gurultu_stft_ozellikleri)
    predictors = np.reshape(
        predictors, (predictors.shape[0], predictors.shape[1], 1, predictors.shape[2]))  # pylint: disable=E1136  # pylint/issues/3139
    predictors = np.transpose(predictors, (3, 0, 1, 2)).astype(np.float32)

    STFTFullyConvolutional = model.predict(predictors)

    gurultusuAyristirilmisSesFullyConvolutional = ozellikleri_sese_geri_donustur(gurultuluSesOzellikCikarici,
                                                                                 STFTFullyConvolutional, gurultuluFaz, mean, std)

    librosa.output.write_wav(
        os.path.join(tempfile.gettempdir(), 'sekte-sonuc.wav'), gurultusuAyristirilmisSesFullyConvolutional, int(sr))
    # ipd.Audio(data=gurultusuAyristirilmisSesFullyConvolutional, rate=sr)  # Yerel Wav yükle

    f, (ax1) = plt.subplots(1, 1, sharey=True)
    ax1.plot(gurultuEklenmisSes)
    image = BytesIO()
    plt.savefig(image, format='png')
    b64Orijinal = base64.encodestring(image.getvalue())

    f, (ax1) = plt.subplots(1, 1, sharey=True)
    ax1.plot(gurultusuAyristirilmisSesFullyConvolutional)
    image = BytesIO()
    plt.savefig(image, format='png')
    b64Gurultusuz = base64.encodestring(image.getvalue())
    return {
        "Orijinal": "{}".format("".join(str(b64Orijinal))),
        "Gurultusuz": "{}".format("".join(str(b64Gurultusuz)))
    }
