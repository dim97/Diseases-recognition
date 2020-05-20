using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryUMLS
{
    public class Dict
    {
        string symptfilePath = "Resources\\symptoms.csv";
        string disfilePath = "Resources\\diseases.csv";
        string symptUMLSFilePath = "Resources\\SymptomsUMLS.csv";
        string disUMLSFilePath = "Resources\\DiseasesUMLS.csv";
        List<Symptom> sympTranslations;
        List<Disease> disTranslations;

        UMLSRequestManager _requestManager;
        public List<Symptom> Symptoms
        {
            get { return sympTranslations; }
        }
        public List<Disease> Diseases
        {
            get { return disTranslations; }
        }
        public List<string> AllDiseasesUMLS
        { get { return Diseases.Select(d => d.UMLS).ToList(); } }
        public List<string> AllDiseasesEng
        { get { return Diseases.Select(d => d.Eng).ToList(); } }
        public List<string> AllSymptomsUMLS
        { get { return Symptoms.Select(d => d.UMLS).ToList(); } }
        public List<string> AllSymptomsEng
        { get { return Symptoms.Select(d => d.Eng).ToList(); } }

        public Dict()
        {
            _requestManager = new UMLSRequestManager();
            //sympTranslations = GetSymptomsByApi(loadCsvFile(symptUMLSFilePath));
            //disTranslations = GetDiseasesByApi(loadCsvFile(disUMLSFilePath));
            sympTranslations = GetSymptoms(loadCsvFile(symptfilePath));
            disTranslations = GetDiseases(loadCsvFile(disfilePath));
        }

        public List<string> loadCsvFile(string filePath)
        {
            var reader = new StreamReader(File.OpenRead(filePath));
            List<string> searchList = new List<string>();

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                searchList.Add(line);
            }

            return searchList;
        }
        public void UpdateSymptomsCsv()
        {
            string csv = String.Empty; 
            var sympFromApi = GetSymptomsByApi(loadCsvFile(symptUMLSFilePath));
            foreach (var item in sympFromApi)
            {
                csv += item.UMLS + ';' + item.Eng + Environment.NewLine;
            }
            File.WriteAllText(symptfilePath, csv);
        }
        public List<Symptom> GetSymptomsByApi(List<string> fileContent)
        {
            List<Symptom> result = new List<Symptom>();
            List<string> translations;
            translations = _requestManager.RequestUmlsTranslations(fileContent);
            for (int i = 0; i < fileContent.Count; i++)
            {
                result.Add(new Symptom() { UMLS = fileContent[i], Eng = translations[i] });
            }
            return result;
        }
        public List<Disease> GetDiseasesByApi(List<string> fileContent)
        {
            List<Disease> result = new List<Disease>();
            List<string> translations = new List<string>();
            translations = _requestManager.RequestUmlsTranslations(fileContent);
            for (int i = 0; i < fileContent.Count; i++)
            {
                result.Add(new Disease() { UMLS = fileContent[i], Eng = translations[i] });
            }
            return result;
        }
        public List<Symptom> GetSymptoms(List<string> fileContent)
        {
            List<Symptom> result = new List<Symptom>();
            foreach (var item in fileContent)
            {
                var pair = item.Split(';');
                Symptom symptom = new Symptom() { UMLS = pair[0], Eng = pair[1] };
                result.Add(symptom);
            }

            return result;
        }
        public List<Disease> GetDiseases(List<string> fileContent)
        {
            List<Disease> result = new List<Disease>();
            foreach (var item in fileContent)
            {
                var pair = item.Split(';');
                Disease disease = new Disease() { UMLS = pair[0], Eng = pair[1] };
                result.Add(disease);
            }

            return result;
        }

        public string UMLSToEng(string input)
        {
            Symptom symptom = Symptoms.Find(s => s.UMLS == input);
            Disease disease = Diseases.Find(s => s.UMLS == input);

            if (symptom != null)
            {
                return symptom.Eng;
            }
            else if (disease != null)
            {
                return disease.Eng;
            }
            else
            {
                return "NOT FOUND";
            }
        }
        public string EngToUMLS(string input)
        {
            Symptom symptom = Symptoms.Find(s => s.Eng == input);
            Disease disease = Diseases.Find(s => s.Eng == input);

            if (symptom != null)
            {
                return symptom.UMLS;
            }
            else if (disease != null)
            {
                return disease.UMLS;
            }
            else
            {
                return "NOT FOUND";
            }
        }

        public List<string> TranslateUmlsByUsingApi(List<string> umlsCollection)
        {
            List<string> result;
            result = _requestManager.RequestUmlsTranslations(umlsCollection);
            return result;
        }
    }
}
