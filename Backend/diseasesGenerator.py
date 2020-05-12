import numpy as np
from math import ceil
import random
import copy

def ExtendDataset(groupedSourceDataset):
    extendedDataset = copy.copy(groupedSourceDataset)
    part1 = AddDiseasesWithLessSymptoms(groupedSourceDataset)
    part2 = AddDiseasesWithMoreSymptoms(groupedSourceDataset)
    part3 = AddDiseasesWithMoreSymptoms(part1)
    extendedDataset = np.append(extendedDataset,part1,axis=0)
    extendedDataset = np.append(extendedDataset,part2,axis=0)
    extendedDataset = np.append(extendedDataset,part3,axis=0)
    np.random.shuffle(extendedDataset)
    return extendedDataset

def AddDiseasesWithLessSymptoms(groupedSourceDataset):
    generatedDataset = []
    for item in groupedSourceDataset:
        disease = copy.copy(item[0])
        symptoms = copy.copy(item[1])
        symptomsCount = len(symptoms)
        lowerSymptomsCountLimit = ceil(symptomsCount/4)
        random.shuffle(symptoms)
        for valuesToRemove in range(symptomsCount-lowerSymptomsCountLimit):
            newSymptoms = copy.copy(symptoms)
            for i in range(valuesToRemove): 
                del newSymptoms[-1]
            generatedDataset.append((disease,newSymptoms))
    return generatedDataset

def AddDiseasesWithMoreSymptoms(groupedSourceDataset):
    allSymptoms = GetAllSymptoms(groupedSourceDataset)
    generatedDataset = []
    for item in groupedSourceDataset:
        disease = copy.copy(item[0])
        symptoms = copy.copy(item[1])
        symptomsCount = len(symptoms)
        extensionLimit = ceil(symptomsCount/5)
        random.shuffle(symptoms)
        for valuesToAdd in range(1,extensionLimit):
            newSymptoms = copy.copy(symptoms)
            newRandomSymptoms = random.sample(list(allSymptoms), valuesToAdd)
            newSymptoms = np.append(newSymptoms,newRandomSymptoms)
            newSymptoms = np.unique(newSymptoms)
            generatedDataset.append((disease,newSymptoms))
    return generatedDataset
                
def GetAllSymptoms(groupedSourceDataset):
    symptoms = copy.copy(np.array([]))
    for item in groupedSourceDataset:
       symptoms = np.append(symptoms,item[1])
    symptoms = np.unique(symptoms)
    return symptoms
