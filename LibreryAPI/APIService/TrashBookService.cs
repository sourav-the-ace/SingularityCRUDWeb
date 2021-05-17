using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreryAPI.APIService
{
    public class TrashBookService
    {
        clsServiceHandler _cls = new clsServiceHandler();
        public string TrashBookList()
        {
            string Data = "";

            string parameter = "Book/GetAllTrashBooks";
            var Res = _cls.GetResponseData(parameter);
            if (Res.IsSuccessStatusCode)
            {
                var EmpResponse = Res.Content.ReadAsStringAsync().Result;
                Data = EmpResponse;
            }

            return Data;

        }

        
        public string RestoreTrashBook(string id)
        {
            string result = "";

            var client = new RestClient("https://localhost:44316/api/Book/RecycleBookInfo?id="+id+"");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            IRestResponse response = client.Execute(request);

            return result;
        }
    }
}
