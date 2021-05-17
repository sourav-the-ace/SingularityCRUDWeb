using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreryAPI.APIService
{
    public class TrashUserService
    {
        clsServiceHandler _cls = new clsServiceHandler();
        public string TrashUserList()
        {
            string Data = "";

            string parameter = "User/GetAllTrashUser";
            var Res = _cls.GetResponseData(parameter);
            if (Res.IsSuccessStatusCode)
            {
                var EmpResponse = Res.Content.ReadAsStringAsync().Result;
                Data = EmpResponse;
            }

            return Data;

        }


        public string RestoreTrashUser(string id)
        {
            string result = "";

            var client = new RestClient("https://localhost:44316/api/User/RecycleUserInfo?id=" + id + "");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            IRestResponse response = client.Execute(request);

            return result;
        }
    }
}
