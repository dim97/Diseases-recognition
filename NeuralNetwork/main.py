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
from math import ceil

# Custom libraries
import dataManager as dm
import callbackExtension
import interfaceManager as im
import diseasesGenerator as dg
import sklearn

# Variables and values
dataSetName = "disease_symptoms_DataSet.csv"
maxEpoch = 8000 # Default value
desiredAcc = 0.9 # Default value

# Program
# Case when user wants to create and train new model
def TrainNewModel():
    RawDataset = dm.LoadData(dataSetName)
    SymptomsCount = dm.CountSymptoms(RawDataset)
    DiseasesCount = dm.CountDiseases(RawDataset)

    # Group symptoms by diseases
    GroupedDataset = dm.GroupByDiseases(RawDataset)

    # Splitting data
    (X, Y) = dm.SplitData(GroupedDataset)  # X-Symptoms, Y-Diseases
    X_train = dm.SymptomsToCategorical(X)
    Y_train = dm.DiseasesToCategorical(Y)
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
    stop_criteria = callbackExtension.TerminateOnBaseline(monitor='acc', baseline=desiredAcc)

    model.fit(
        X_train,
        Y_train,
        batch_size=DiseasesCount,
        epochs=maxEpoch,
        verbose=1,
        callbacks=[csv_logger, stop_criteria]
    )

    print("\nResults on original set:")
    results = model.evaluate(X_test, Y_test, batch_size=128)
    print('test loss, test acc:', results)

    GeneratedDataset = dg.ExtendDataset(GroupedDataset) 
    (X, Y) = dm.SplitData(GeneratedDataset)  # X-Symptoms, Y-Diseases
    XTestGen = dm.SymptomsToCategorical(X)
    YTestGen = dm.DiseasesToCategorical(Y)

    print("\nResults on generated set:")
    resultsOnGeneratedSet = model.evaluate(XTestGen, YTestGen, batch_size=128)
    print('test loss, test acc:', resultsOnGeneratedSet)

    #print("\nPredictions:", end='')
    predictions = model.predict(X_train)
    pd.DataFrame(predictions).to_csv("predictions_pre-trained.csv")
    #print(predictions)

    #Saving model
    model.save("Models/pre-trained_model(acc="+ str(round(resultsOnGeneratedSet[1],4))+ ";"+str(round(results[1],4)) +").h5")

# Case when user wants to continue training existing model
def TrainExistingModel(pathToModel):
    RawDataset = dm.LoadData(dataSetName)
    SymptomsCount = dm.CountSymptoms(RawDataset)
    DiseasesCount = dm.CountDiseases(RawDataset)
    GroupedDataset = dm.GroupByDiseases(RawDataset)
    GeneratedDataset = dg.ExtendDataset(GroupedDataset) 

    (XOriginal, YOriginal) = dm.SplitData(GroupedDataset) 
    XTestOriginal = dm.SymptomsToCategorical(XOriginal)
    YTestOriginal = dm.DiseasesToCategorical(YOriginal)
    # Splitting data
    (X, Y) = dm.SplitData(GeneratedDataset)  # X-Symptoms, Y-Diseases
    X = dm.SymptomsToCategorical(X)
    Y = dm.DiseasesToCategorical(Y)

    X_train, X_test, Y_train, Y_test = sklearn.model_selection.train_test_split(X,Y,test_size=0.1,shuffle=True)

    pd.DataFrame(X_train).to_csv("X_generated.csv") # save to .csv
    pd.DataFrame(Y_train).to_csv("Y_generated.csv") # save to .csv

    csv_logger = CSVLogger('log.csv', append=True, separator=';')
    stop_criteria = callbackExtension.TerminateOnBaseline(monitor='acc', baseline=desiredAcc)
    model = keras.models.load_model(pathToModel)
    model.fit(
        X_train,
        Y_train,
        batch_size=DiseasesCount,
        epochs=maxEpoch,
        verbose=1,
        callbacks=[csv_logger, stop_criteria])

    print("\nResults on generated set:")
    results = model.evaluate(X_test, Y_test, batch_size=128)
    print('test loss, test acc:', results)

    print("\nResults on original set:")
    resultsOnOriginalSet = model.evaluate(XTestOriginal, YTestOriginal, batch_size=128)
    print('test loss, test acc:', resultsOnOriginalSet)

    predictions = model.predict(X_train)
    pd.DataFrame(predictions).to_csv("predictions_full-trained.csv")

    model.save("Models/full-trained_model(acc="+ str(round(results[1],4)) + ";"+str(round(resultsOnOriginalSet[1],4))+").h5")

# Entry point of main program
im.PrintDelimiter()
workingMode = im.RequestWorkingMode()
if workingMode == 1: 
    maxEpoch = im.RequestEpochLimit()
    desiredAcc = im.RequestAccuracy()
    TrainNewModel()
if workingMode == 2:
    modelName = im.RequestModelFile()
    pathToModel = "Models/"+modelName
    maxEpoch = im.RequestEpochLimit()
    desiredAcc = im.RequestAccuracy()
    TrainExistingModel(pathToModel)


#Saving model
#model.save('my_model.h5')
#Loading model
#new_model = keras.models.load_model('my_model.h5')


