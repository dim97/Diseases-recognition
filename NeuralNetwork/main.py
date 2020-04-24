# Use Python 3.6.* !
# TensorFlow and tf.keras
import tensorflow as tf
from tensorflow import keras

# Secondary libraries
import numpy as np
import matplotlib.pyplot as plt
from sklearn import datasets, linear_model
import numpy as np
import pandas as pd

#Program
datasetName = "disease_symptoms_DataSet.csv"
print("Loading data")
combinedData = pd.read_csv(datasetName , sep = ',') 
print("Data loaded!\nExamples(Head): ")
print ( combinedData.head())
