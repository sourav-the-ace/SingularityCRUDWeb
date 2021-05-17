using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreryAPI.APIService
{
    public class RegistrationService
    {
        public string RegistrationInfo(string Name, string Email, string LoginName, string Password, string UserType)
        {
            string result = "";

            var client = new RestClient("https://localhost:44316/api/User/PostUserInfo?name="+ Name + "&email="+ Email + "&loginName="+ LoginName + "&loginPass="+ Password + "&userType="+ UserType + "");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            IRestResponse response = client.Execute(request);

            return result;
        }
    }
}
