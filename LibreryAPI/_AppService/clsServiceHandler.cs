using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LibreryAPI.APIService
{
    public class clsServiceHandler
    {
        public HttpResponseMessage GetResponseData(string parameter)
        {

            var Baseurl = "https://localhost:44316/api/" + parameter;
            var client = new HttpClient();
            client.BaseAddress = new Uri(Baseurl);
            client.DefaultRequestHeaders.Clear();

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var Res = client.GetAsync("").Result;
            return Res;
        }
        public HttpResponseMessage PostResponse(string objectData,string parameter)
        {

            var Baseurl = "https://localhost:44316/api/";
            if(parameter != null)
            {
                Baseurl += parameter;
            }
            var client = new HttpClient();
            client.BaseAddress = new Uri(Baseurl);
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpContent content = new StringContent(objectData, Encoding.UTF8, "application/json");
            var Res = client.PostAsync(Baseurl, content).Result;
            return Res;
        }


    }
}
