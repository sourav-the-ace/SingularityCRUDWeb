using LibreryAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Web.Helpers;
using Microsoft.Ajax.Utilities;
using System.Net.Http;
using System.Net.Http.Headers;
using System.IO;
using System.Web;

namespace LibreryAPI.APIService
{
    public class LoginService
    {
        clsServiceHandler _cls = new clsServiceHandler();

        public string LoginUser(string Email, string Password)
        {
            string data = "";
            string parameter = "User/Login/"+Email+"/"+Password;
            var Res = _cls.GetResponseData(parameter);
            if (Res.IsSuccessStatusCode)
            {

                var EmpResponse = Res.Content.ReadAsStringAsync().Result;
                using (var sr = new StringReader(EmpResponse))
                using (var jr = new JsonTextReader(sr))
                {
                    var serial = new JsonSerializer();
                    serial.Formatting = Formatting.Indented;
                    var obj = serial.Deserialize<LoginInfo>(jr);


                    var e =obj.Data[0].useR_LOGIN_NAME;
                    var f = obj.Data[0].useR_TYPE;
                    HttpContext.Current.Session["userLoginName"] = obj.Data[0].useR_LOGIN_NAME.ToString();
                    HttpContext.Current.Session["UserRole"] = obj.Data[0].useR_TYPE.ToString();

                    data = "Success";


                }
            }
            else
            {
                data = "Failure";
            }

            return data;
        }
    }
}
