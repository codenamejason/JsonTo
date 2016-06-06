using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace JsonTo
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = "";
            string json = "{\"test\":true,\"test2\":false}";
            using (var client = new HttpClient())
            {
                string url = "https://json-csv.com/api/getcsv";
                var content = new FormUrlEncodedContent(new[]
                {
                    new System.Collections.Generic.KeyValuePair("email", email),
                    new System.Collections.Generic.KeyValuePair("json", json),
                });
                var result = client.PostAsync(url, content).Result;
                string csvContent = result.Content.ReadAsStringAsync().Result;
                Response.Write(csvContent);
            }

        }
    }
}
