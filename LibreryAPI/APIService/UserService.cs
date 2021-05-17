using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreryAPI.APIService
{
    public class UserService
    {
        clsServiceHandler _cls = new clsServiceHandler();

        public string GetUserList()
        {
            string Data = "";
            string parameter = "User/GetAllUser";
            var Res = _cls.GetResponseData(parameter);
            if (Res.IsSuccessStatusCode)
            {
                var EmpResponse = Res.Content.ReadAsStringAsync().Result;
                Data = EmpResponse;
            }

            return Data;
        }

        public string DeleteUserInfo(string userId)
        {
            string result = "";

            var client = new RestClient("https://localhost:44316/api/User/DeleteUserInfo?id=" + userId + "");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            IRestResponse response = client.Execute(request);

            return result;
        }

        public string UpdatedUserInfo(string UserId, string UserName, string Email, string LoginName)
        {
            string result = "";

            var client = new RestClient("https://localhost:44316/api/User/UpdateUserInfo?id="+ UserId + "&name="+ UserName + "&email="+ Email + "%40gmail.com&loginName="+ LoginName + "");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            IRestResponse response = client.Execute(request);

            return result;


        }

    }
}