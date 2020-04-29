# Use Python 3.6.* !
# TensorFlow and tf.keras
import tensorflow as tf
from tensorflow import keras

# Secondary libraries
from termcolor import colored
import numpy as np
import matplotlib.pyplot as plt
from sklearn import datasets, linear_model
import numpy as np
import pandas as pd
from keras.utils import plot_model
from keras.datasets import mnist
from itertools import groupby
import collections
from keras import utils
from sklearn.preprocessing import MultiLabelBinarizer
from keras.callbacks.callbacks import CSVLogger

# Program
print("\n\n\n********************** Start of main program **********************")
datasetName = "disease_symptoms_DataSet.csv"
print("\nLoading data", end='')
RawDataset = pd.read_csv(datasetName, sep=',')
print(colored("  - OK", 'green'))
#print("\nData examples (Head): ")
#print ("        " + RawDataset.head())
print("\nGetting all symptoms and diseases from dataset", end='')
AllSymptoms = RawDataset.values[:, 1]
AllSymptoms = list(dict.fromkeys(AllSymptoms))
SymptomsCount = len(AllSymptoms)
AllDiseases = RawDataset.values[:, 0]
AllDiseases = list(dict.fromkeys(AllDiseases))
DiseasesCount = len(AllDiseases)
print(colored("  - OK", 'green'))
#print("Symptoms : "+ str(SymptomsCount) + "   Diseases : "+ str(DiseasesCount))

# Group symptoms by diseases
DictDataset = collections.defaultdict(list)
for item in RawDataset.values:
    DictDataset[item[0]].append(item[1])
GroupedDataset = np.array(list(DictDataset.items()))

# Splitting data
(X, Y) = (GroupedDataset[:, 1], GroupedDataset[:, 0])  # X-Symptoms, Y-Diseases
#X_train = pd.get_dummies(pd.Series(X).apply(pd.Series).stack()).sum(level=0)
mlb = MultiLabelBinarizer()
X_train = pd.DataFrame(mlb.fit_transform(
    X), columns=mlb.classes_, index=pd.DataFrame(X).index)
X_test = X_train
# Diseases from UMLS to array of indexes [0,0,0,....,0,1,0,...]
Y_train = pd.get_dummies(Y)
Y_test = Y_train

pd.DataFrame(X_train).to_csv("X.csv")
pd.DataFrame(Y_train).to_csv("Y.csv")

model = keras.Sequential([
    keras.layers.Dense(800, input_dim=SymptomsCount, activation="relu"),
    keras.layers.Dense(500, input_dim=SymptomsCount, activation="relu"),
    keras.layers.Dense(DiseasesCount, activation="softmax"),
])

model.compile(loss="categorical_crossentropy",
              optimizer="SGD",
              metrics=["accuracy"])

print(model.summary())

csv_logger = CSVLogger('log.csv', append=True, separator=';')
print("\nLearning start", end='')
model.fit(
    X_train,
    Y_train,
    batch_size=DiseasesCount,
    epochs=8000,
    verbose=1,
    callbacks=[csv_logger]
)

print(colored("  - OK", 'green'))
print("\nPredictions:", end='')
predictions = model.predict(X_train)
pd.DataFrame(predictions).to_csv("predictions.csv")
print(predictions)