import numpy as np
import soundfile as sf

import matplotlib.pyplot as plt

import params
import yamnet as yamnet_model
import tensorflow as tf

wav_dosya_adi = 'wav/tone_440.wav'

wav_veri, sr = sf.read(wav_dosya_adi)
wav_veri = (wav_veri * 32767).astype(np.int16)
dalgaformu = wav_veri / 32768.0

params.SAMPLE_RATE = sr
print("Örnekleme Oranı =", params.SAMPLE_RATE)

# YAMNet model kurulumu
siniflandirma_isimleri = yamnet_model.class_names('yamnet_class_map.csv')
params.PATCH_HOP_SECONDS = 0.1  # 10 Hz 
graph = tf.Graph()
with graph.as_default():
    yamnet = yamnet_model.yamnet_frames_model(params)
    yamnet.load_weights('yamnet.h5')
    
# Modeli çalıştır.
with graph.as_default():
    skorlar, spektrogram = yamnet.predict(np.reshape(dalgaformu, [1, -1]), steps=1)
    
# Sonucu görselleştir
plt.figure(figsize=(10, 8))

# Dalga formunu çiz
plt.subplot(3, 1, 1)
plt.plot(dalgaformu)
plt.xlim([0, len(dalgaformu)])
# Modelden dönen log-mel spektogramı çiz.
plt.subplot(3, 1, 2)
plt.imshow(spektrogram.T, aspect='auto', interpolation='nearest', origin='bottom')

# En yüksek skor alan sınıflar için model çıktı puanlarını çiz ve etiketlerini yaz.
ortalama_skorlar = np.mean(skorlar, axis=0)
ustten_N = 10
ust_sinif_endeksleri = np.argsort(ortalama_skorlar)[::-1][:ustten_N]
plt.subplot(3, 1, 3)
plt.imshow(skorlar[:, ust_sinif_endeksleri].T, aspect='auto', interpolation='nearest', cmap='gray_r')
# Spektrograma hizalamak için PATCH_WINDOW_SECONDS (0.96 s) göze alınıyor
patch_padding = (params.PATCH_WINDOW_SECONDS / 2) / params.PATCH_HOP_SECONDS
plt.xlim([-patch_padding, skorlar.shape[0] + patch_padding])
# En üstten N sınıfın etiketlerini yaz.
yticks = range(0, ustten_N, 1)
plt.yticks(yticks, [siniflandirma_isimleri[ust_sinif_endeksleri[x]] for x in yticks])
_ = plt.ylim(-0.5 + np.array([ustten_N, 0]))