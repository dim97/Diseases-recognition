import pandas as pd
import collections
import numpy as np
from sklearn.preprocessing import MultiLabelBinarizer


def LoadData(path):
    return pd.read_csv(path, sep=',')

def CountSymptoms(dataset):
    AllSymptoms = dataset.values[:, 1]
    #AllSymptoms = list(dict.fromkeys(AllSymptoms))
    #SymptomsCount = len(AllSymptoms)
    AllSymptoms = np.unique(AllSymptoms)
    SymptomsCount = len(AllSymptoms)
    return SymptomsCount

def CountDiseases(dataset):
    AllDiseases = dataset.values[:, 0]
    AllDiseases = list(dict.fromkeys(AllDiseases))
    DiseasesCount = len(AllDiseases)
    return DiseasesCount

def GroupByDiseases(dataset):
    DictDataset = collections.defaultdict(list)
    for item in dataset.values:
        DictDataset[item[0]].append(item[1])
    GroupedDataset = np.array(list(DictDataset.items())) 
    return GroupedDataset

def SplitData(dataset):
    return (dataset[:, 1], dataset[:, 0])

def SymptomsToCategorical(groupedSymptoms):
    # Symptoms from UMLS to array of indexes [0,1,0,....,1,1,0,...]
    mlb = MultiLabelBinarizer()
    X_train = pd.DataFrame(mlb.fit_transform(groupedSymptoms), columns=mlb.classes_, index=pd.DataFrame(groupedSymptoms).index)
    dictionary = X_train.columns.values
    pd.DataFrame(dictionary).to_csv("SymptomsDict.csv")
    return X_train

def DiseasesToCategorical(groupedDiseases):
    # Diseases from UMLS to array of indexes [0,0,0,....,0,1,0,...]
    Y_train = pd.get_dummies(groupedDiseases)
    dictionary = Y_train.columns.values
    pd.DataFrame(dictionary).to_csv("DiseasesDict.csv")
    return Y_train

def TranslatePredictionsToDiseases(predictions):
    output = []
    values = predictions[0]
    diseasesDictionary = LoadData("DiseasesDict.csv").values[:,1]
    for i in range(len(values)):
        disease = diseasesDictionary[i]
        probability = values[i]
        output.append((disease,probability))
    return output

    position = input.tolist().index(1)
    result = diseasesDictionary[position]
    #####


def TranslateSymptomsToCategorical(input):
    symptomsDictionary = LoadData("SymptomsDict.csv").values[:,1].tolist()
    symCount = len(symptomsDictionary)
    output = [0] * symCount
    for x in input:
        position = symptomsDictionary.index(x)
        output[position] = 1
    return output
    #####