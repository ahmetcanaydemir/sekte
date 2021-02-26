import numpy as np
import soundfile as sf
import matplotlib.pyplot as plt
import yamnet.params as params
import tensorflow as tf
import base64
from io import BytesIO
import tempfile
import librosa
import os


def SekteDetay(yamnet_model, soundPath):
    wav_veri, sr = librosa.load(soundPath)
    wav_veri = (wav_veri * 32767).astype(np.int16)
    dalgaformu = wav_veri / 32768.0

    params.SAMPLE_RATE = sr
    print("Örnekleme Oranı =", params.SAMPLE_RATE)

    # YAMNet model kurulumu
    siniflandirma_isimleri = yamnet_model.class_names(os.path.join(
        'yamnet', 'yamnet_class_map.csv'))
    params.PATCH_HOP_SECONDS = 0.1  # 10 Hz
    graph = tf.Graph()
    with graph.as_default():
        yamnet = yamnet_model.yamnet_frames_model(params)
        yamnet.load_weights(os.path.join(
            'yamnet', 'yamnet.h5'))

    # Modeli çalıştır.
    with graph.as_default():
        skorlar, spektrogram = yamnet.predict(
            np.reshape(dalgaformu, [1, -1]), steps=1)

    # Sonucu görselleştir
    plt.figure(figsize=(10, 8))

    # Modelden dönen log-mel spektogramı çiz.
    plt.subplot(1, 1, 1)
    plt.imshow(spektrogram.T, aspect='auto',
               interpolation='nearest', origin='bottom')

    image = BytesIO()
    plt.savefig(image, format='png')
    spektogramImg = base64.encodestring(image.getvalue())
    plt.clf()
    # En yüksek skor alan sınıflar için model çıktı puanlarını çiz ve etiketlerini yaz.
    ortalama_skorlar = np.mean(skorlar, axis=0)
    ustten_N = 10
    ust_sinif_endeksleri = np.argsort(ortalama_skorlar)[::-1][:ustten_N]
    plt.subplot(1, 1, 1)
    plt.imshow(skorlar[:, ust_sinif_endeksleri].T, aspect='auto',
               interpolation='nearest', cmap='gray_r')
    # Spektrograma hizalamak için PATCH_WINDOW_SECONDS (0.96 s) göze alınıyor
    patch_padding = (params.PATCH_WINDOW_SECONDS / 2) / \
        params.PATCH_HOP_SECONDS
    plt.xlim([-patch_padding, skorlar.shape[0] + patch_padding])
    # En üstten N sınıfın etiketlerini yaz.
    yticks = range(0, ustten_N, 1)
    plt.yticks(yticks, [siniflandirma_isimleri[ust_sinif_endeksleri[x]]
                        for x in yticks])
    _ = plt.ylim(-0.5 + np.array([ustten_N, 0]))
    image = BytesIO()
    plt.savefig(image, format='png')
    detaylarImg = base64.encodestring(image.getvalue())
    return {
        "Spektogram": "{}".format("".join(str(spektogramImg))),
        "Detaylar": "{}".format("".join(str(detaylarImg)))
    }
