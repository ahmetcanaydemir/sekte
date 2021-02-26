from flask import Flask, request, jsonify
from flask_cors import CORS, cross_origin
import pickle
from tensorflow.keras.models import load_model
from sekte import Sekte
from detay import SekteDetay
import yamnet.yamnet as yamnet_model
import os


app = Flask(__name__)
cors = CORS(app)
app.config['CORS_HEADERS'] = 'Content-Type'

MODEL_FILENAME = os.path.join("libsekte", "sekte_model.h5")


model = load_model(MODEL_FILENAME)
@app.route('/', methods=['POST', 'GET', 'OPTIONS'])
@cross_origin()
def server():
    dosyayolu = request.args.get('dosya', 'common_voice_en_100005.mp3')
    return jsonify(Sekte(model, dosyayolu))


@app.route('/detay', methods=['POST', 'GET', 'OPTIONS'])
@cross_origin()
def detay():
    dosyayolu = request.args.get('dosya', 'common_voice_en_100005.mp3')
    return jsonify(SekteDetay(yamnet_model, dosyayolu))
