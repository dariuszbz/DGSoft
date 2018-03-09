using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WebDocs.Models;


namespace WebDocs.Proxy
{
    public static class WebDocsProxy
    {
        static HttpClient client = new HttpClient();
        private const string apiPath = "api/Documents/";

        static WebDocsProxy()
        {
            client.BaseAddress = new Uri("https://localhost:44391/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static List<WebDoc> GetDocsFromApi()
        {
            List<WebDoc> documents = null;
            HttpResponseMessage response = client.GetAsync("api/Documents/").Result;
            
            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                documents = JsonConvert.DeserializeObject<List<WebDoc>>(json);
            }
            return documents;
        }
    }
}