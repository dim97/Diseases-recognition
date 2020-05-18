using DictionaryUMLS;
using HttpRequestManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_UI
{
    public class DataManager
    {
        Dict dictUMLS;

        public DataManager()
        {
            dictUMLS = new Dict();
        }

        public List<(string, double)> GetSortedPredictions( List<string> input )
        {
            RequestManager requestManager = new RequestManager();
            List<(string, double)> result = requestManager.GetResponse(input);

            var resultToShow = result.OrderByDescending(r => r.Item2).ToList();
            return resultToShow;
        }

        public List<Symptom> GetAllSymptoms()
        {
            return dictUMLS.Symptoms;
        }

        public List<Disease> GetAllDiseases()
        {
            return dictUMLS.Diseases;
        }

        public string TranslateSymptomUMLSToEng(string input)
        {
            var symptoms = GetAllSymptoms();
            foreach (var symptom in symptoms)
            {
                if (symptom.UMLS == input)
                {
                    return symptom.Eng;
                }
            }

            return string.Empty;
        }
        public string TranslateDiseasesUMLSToEng(string input)
        {
            var diseases = GetAllDiseases();
            foreach (var disease in diseases)
            {
                if (disease.UMLS == input)
                {
                    return disease.Eng;
                }
            }

            return string.Empty;
        }
        public string TranslateDiseaseEngToUMLS(string input)
        {
            var diseases = GetAllDiseases();
            foreach (var disease in diseases)
            {
                if (disease.Eng == input)
                {
                    return disease.UMLS;
                }
            }

            return string.Empty;
        }
        public string TranslateSymptomEngToUMLS(string input)
        {
            var symptoms = GetAllSymptoms();
            foreach (var symptom in symptoms)
            {
                if (symptom.UMLS == input)
                {
                    return symptom.Eng;
                }
            }

            return string.Empty;
        }
    }
}
