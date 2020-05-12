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
    return X_train

def DiseasesToCategorical(groupedDiseases):
    # Diseases from UMLS to array of indexes [0,0,0,....,0,1,0,...]
    Y_train = pd.get_dummies(groupedDiseases)
    return Y_train