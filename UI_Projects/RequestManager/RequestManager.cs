using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HttpRequestManager
{
    public class RequestManager
    {
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
                string message = "Server could not process your request.\nTry to use another input or just try again later";
                string title = "Request error";
                MessageBox.Show(message, title);
                return null;
            }
        }

    }
}
