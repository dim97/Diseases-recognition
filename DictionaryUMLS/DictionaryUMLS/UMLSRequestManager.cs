using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryUMLS
{
    public class UMLSRequestManager
    {
        public string RequestTGT()
        {
            string url = @"https://utslogin.nlm.nih.gov/cas/v1/api-key";
            string apikey = "?apikey=132788c7-4d18-47ab-9326-952c25776e82";

            string requestString = url + apikey;

            var request = (HttpWebRequest)WebRequest.Create(requestString);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            var response = (HttpWebResponse)request.GetResponse();

            if (response.StatusCode == HttpStatusCode.Created)
            {
                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

                int tgtStart = responseString.IndexOf("TGT-");
                int tgtEnd = responseString.IndexOf("-cas") + 4;

                string tgt = responseString.Substring(tgtStart, tgtEnd - tgtStart);

                return tgt;
            }
            else
            {
                return null;
            }
        }

        public string RequestServiceTicket(string tgt)
        {
            string url = @"https://utslogin.nlm.nih.gov/cas/v1/tickets/";
            string service = "?service=http://umlsks.nlm.nih.gov";
            if (tgt != String.Empty)
            {
                string requestString = url + tgt + service;

                var request = (HttpWebRequest)WebRequest.Create(requestString);
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                var response = (HttpWebResponse)request.GetResponse();

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    string serviceTicket = new StreamReader(response.GetResponseStream()).ReadToEnd();
                    return serviceTicket;
                }
                else
                {
                    return String.Empty;
                }
            }
            else
            {
                return String.Empty;
            }
        }
        public string RequestTranslation(string umls, string serviceTicket)
        {
            string url = @"https://uts-ws.nlm.nih.gov/rest/content/current/CUI/";

            if ((umls != String.Empty) && (serviceTicket != String.Empty))
            {
                string requestString = url + umls + '?' + "ticket=" + serviceTicket;

                var request = (HttpWebRequest)WebRequest.Create(requestString);
                request.Method = "GET";
                request.ContentType = "application/x-www-form-urlencoded";
                HttpWebResponse response = null;
                try
                {
                    response = (HttpWebResponse)request.GetResponse();
                }
                catch(WebException wex)
                {
                    return umls;
                }

                if ((response!=null)&&(response.StatusCode == HttpStatusCode.OK))
                {
                    string responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

                    string nameField = "\"name\":\"";
                    int nameStart = responseString.LastIndexOf(nameField) + nameField.Length;
                    string nameEng = responseString.Substring(nameStart);
                    int nameEnd = nameEng.IndexOf("\"");
                    nameEng = nameEng.Substring(0, nameEnd);

                    return nameEng;
                }
                else
                {
                    return String.Empty;
                }
            }
            else
            {
                return String.Empty;
            }
        }

        public List<string> RequestUmlsTranslations(List<string> umls)
        {
            List<string> result = new List<string>();

            string tgt = RequestTGT();
            foreach (var item in umls)
            {
                string ticket = RequestServiceTicket(tgt);
                result.Add(RequestTranslation(item,ticket));
            }

            return result;
        }

        public List<(string, double)> GetResponse(List<string> requestData)
        {
            string url = @"http://dim97.pythonanywhere.com";

            string json = JsonConvert.SerializeObject(requestData);

            var body = Encoding.UTF8.GetBytes(json);
            var request = (HttpWebRequest)WebRequest.Create(url);

            request.Method = "POST";
            request.ContentType = "application/json";
            request.ContentLength = body.Length;

            using (var stream = request.GetRequestStream())
            {
                stream.Write(body, 0, body.Length);
            }

            var response = (HttpWebResponse)request.GetResponse();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                var result = JsonConvert.DeserializeObject<List<Dictionary<string, double>>>(responseString);
                List<(string, double)> output = new List<(string, double)>();
                foreach (var item in result)
                {
                    var key = (item.Keys).ToList()[0];
                    var value = (item.Values).ToList()[0];
                    output.Add((key, value));
                }

                return output;
            }
            else
            {
                return null;
            }
        }
    }
}
