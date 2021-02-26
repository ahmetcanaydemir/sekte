import librosa
import numpy


class OzellikCikarici:
    def __init__(self, ses, *, pencereBuyuklugu, overlap, ornekleme_orani):
        self.ses = ses
        self.ffT_uzunlugu = pencereBuyuklugu
        self.pencere_buyuklugu = pencereBuyuklugu
        self.overlap = overlap
        self.ornekleme_orani = ornekleme_orani
        self.pencere = numpy.hamming(self.pencere_buyuklugu)

    def stft_spektogrami_getir(self):
        return librosa.stft(self.ses, n_fft=self.ffT_uzunlugu, win_length=self.pencere_buyuklugu, hop_length=self.overlap,
                            window=self.pencere, center=True)

    def stft_spektogramindan_sesi_getir(self, stft_ozellikleri):
        return librosa.istft(stft_ozellikleri, win_length=self.pencere_buyuklugu, hop_length=self.overlap,
                             window=self.pencere, center=True)

    def mel_spectrogrami_getir(self):
        return librosa.feature.melspectrogram(self.ses, sr=self.ornekleme_orani, power=2.0, pad_mode='reflect',
                                              n_fft=self.ffT_uzunlugu, hop_length=self.overlap, center=True)

    def mel_spectrogramindan_sesi_getir(self, M):
        return librosa.feature.inverse.mel_to_audio(M, sr=self.ornekleme_orani, n_fft=self.ffT_uzunlugu,
                                                    hop_length=self.overlap,
                                                    win_length=self.pencere_buyuklugu, window=self.pencere,
                                                    center=True, pad_mode='reflect', power=2.0, n_iter=32, length=None)
