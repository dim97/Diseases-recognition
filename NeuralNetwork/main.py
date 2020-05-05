# Use Python 3.6.* 
# TensorFlow and tf.keras
import tensorflow as tf
#from tensorflow import keras
import plaidml.keras
import os
plaidml.keras.install_backend()
os.environ["KERAS_BACKEND"] = "plaidml.keras.backend"
import keras

# Secondary libraries
from termcolor import colored
import numpy as np
import matplotlib.pyplot as plt
from sklearn import datasets, linear_model
import numpy as np
import pandas as pd
from keras.datasets import mnist
from itertools import groupby
import collections
from keras import utils
from sklearn.preprocessing import MultiLabelBinarizer
from keras.callbacks import CSVLogger, EarlyStopping

# Custom libraries
import dataManager, callbackExtension
from math import ceil

# Program
print("\n\n\n********************** Start of main program **********************")
dataSetName = "disease_symptoms_DataSet.csv"
RawDataset = dataManager.LoadData(dataSetName)
SymptomsCount = dataManager.CountSymptoms(RawDataset)
DiseasesCount = dataManager.CountDiseases(RawDataset)

# Group symptoms by diseases
GroupedDataset = dataManager.GroupByDiseases(RawDataset)

# Splitting data
(X, Y) = dataManager.SplitData(GroupedDataset)  # X-Symptoms, Y-Diseases
X_train = dataManager.SymptomsToCategorical(X)
Y_train = dataManager.DiseasesToCategorical(Y)
X_test = X_train
Y_test = Y_train

pd.DataFrame(X_train).to_csv("X.csv") # save to .csv
pd.DataFrame(Y_train).to_csv("Y.csv") # save to .csv

# Defining model
deltaOfInOut = abs(SymptomsCount-DiseasesCount)
avgOfInOut = ceil((abs(SymptomsCount+DiseasesCount)/2))

(firstLayerNeuronCount, secondLayerNeuronCount) = (ceil(avgOfInOut+deltaOfInOut/4),ceil(avgOfInOut-deltaOfInOut/4))

model = keras.Sequential([
    keras.layers.Dense(firstLayerNeuronCount, input_dim=SymptomsCount, activation="relu"),
    keras.layers.Dense(secondLayerNeuronCount, activation="relu"),
    keras.layers.Dense(DiseasesCount, activation="softmax"),
])

model.compile(loss="categorical_crossentropy",
              optimizer="SGD",
              metrics=["accuracy"])

print(model.summary())

csv_logger = CSVLogger('log.csv', append=True, separator=';')
stop_criteria = callbackExtension.TerminateOnBaseline(monitor='acc', baseline=0.1)
print("\nLearning start", end='')
model.fit(
    X_train,
    Y_train,
    batch_size=DiseasesCount,
    epochs=8000,
    verbose=1,
    callbacks=[csv_logger, stop_criteria]
)

print(colored("  - OK", 'green'))
print("\nPredictions:", end='')
predictions = model.predict(X_train)
pd.DataFrame(predictions).to_csv("predictions.csv")
print(predictions)

#Saving model
model.save('my_model.h5')
#Loading model
new_model = keras.models.load_model('my_model.h5')

