from flask import Flask
from flask import request
from tensorflow import keras
import json

import dataManager as dm
import numpy as np
import pandas as pd

app = Flask(__name__)

class NumpyEncoder(json.JSONEncoder):
    def default(self, obj):
        if isinstance(obj, np.ndarray):
            return obj.tolist()
        return json.JSONEncoder.default(self, obj)

@app.route("/", methods=['POST'])
def index():
    inputSymptoms = request.json
    inputValues = [dm.TranslateSymptomsToCategorical(inputSymptoms)]

    model = keras.models.load_model("Model.h5")
    predictions = model.predict(inputValues)

    result = dm.TranslatePredictionsToDiseases(predictions)
    json_values = ""
    for x in result:
        json_values = json_values + '{"'+x[0]+'":'+str(x[1])+'},'
    json_values = json_values[:-1]
    httpResult = '['+json_values+']'
    return httpResult

if __name__ == "__main__":
    app.run(host='0.0.0.0', port=4567)