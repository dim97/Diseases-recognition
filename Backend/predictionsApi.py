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

@app.route("/", methods=['GET'])
def index():
    inputSymptoms = request.json
    inputValues = [dm.TranslateSymptomsToCategorical(inputSymptoms)]

    model = keras.models.load_model("Model.h5")
    predictions = model.predict(inputValues)

    result = dm.TranslatePredictionsToDiseases(predictions)
    print(result)
    serializableResult = []
    for x in result:
        serializableResult.append((x[0],str(x[1])))

    json_dump = json.dumps(serializableResult)
    return json_dump

if __name__ == "__main__":
    app.run(host='0.0.0.0', port=4567)
