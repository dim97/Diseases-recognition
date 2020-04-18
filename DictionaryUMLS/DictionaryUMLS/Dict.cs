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
        public List<Symptom> Symptoms { get; set; }
        public List<Disease> Diseases { get; set; }
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
            Symptoms = new List<Symptom>();
            Diseases = new List<Disease>();

            string SymptfilePath = "Resources\\symptoms.csv";
            string DisfilePath = "Resources\\diseases.csv";

            Symptoms = GetSymptoms(loadCsvFile(SymptfilePath));
            Diseases = GetDiseases(loadCsvFile(DisfilePath));
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
    }
}
