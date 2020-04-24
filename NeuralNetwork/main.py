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

#Program
print("\n\n\n********************** Start of main program **********************")
datasetName = "disease_symptoms_DataSet.csv"
print("\nLoading data", end = '')
Dataset = pd.read_csv(datasetName , sep = ',') 
print(colored( "  - OK",'green'))
print("\nData examples (Head): ")
print ("        " + Dataset.head())
print("\nGetting all symptoms and diseases from dataset", end = '')
AllSymptoms = Dataset.values[:,1]
AllSymptoms = list(dict.fromkeys(AllSymptoms))
SymptomsCount = len(AllSymptoms)
AllDiseases = Dataset.values[:,0]
AllDiseases = list(dict.fromkeys(AllDiseases))
DiseasesCount = len(AllDiseases)
print(colored( "  - OK",'green'))
print("Symptoms : "+ str(SymptomsCount) + "   Diseases : "+ str(DiseasesCount))

(X,Y) = (Dataset.values[:,1],Dataset.values[:,0])
X_train = X
X_test = X_train

model = keras.Sequential([
    keras.layers.Dense(SymptomsCount, input_shape = (SymptomsCount,)),
    keras.layers.Activation('relu'),
    keras.layers.Dense(128,),
    keras.layers.Activation('relu'),
    keras.layers.Dense(DiseasesCount),
    keras.layers.Activation('softmax'),
])

model.compile(loss='binary_crossentropy',
              optimizer='adam',
              metrics=['accuracy'])

model.summary()