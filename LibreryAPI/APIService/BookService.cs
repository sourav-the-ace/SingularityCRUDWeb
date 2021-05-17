using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Helpers;
using LibreryAPI.Models;
using Newtonsoft.Json;
using RestSharp;

namespace LibreryAPI.APIService
{
    public class BookService
    {

        clsServiceHandler _cls = new clsServiceHandler();

        public string BookList()
        {
            string Data = "";

            string parameter = "Book/GetAllBooks";
            var Res = _cls.GetResponseData(parameter);
            if (Res.IsSuccessStatusCode)
            {
                var EmpResponse = Res.Content.ReadAsStringAsync().Result;
                Data = EmpResponse;
            }

            return Data;

        }

        //public string AddBookInfo(string BookName,string  BookAuthor,string BookGenre)
        //{
        //    string result = "";
        //    var userObject = new AddBookClass();

        //    userObject.name = BookName;
        //    userObject.authorName = BookAuthor;
        //    userObject.genre = BookGenre;
        //    string objectData = Json.Encode(userObject);
        //    string parameter = "Book/PostBookInfo";

        //    HttpResponseMessage Res = _cls.PostResponse(objectData, parameter);
        //    if (Res.IsSuccessStatusCode)
        //    {
        //        var EmpResponse = Res.Content.ReadAsStringAsync().Result;
        //        result = EmpResponse;
        //    }

        //        return result;
        //}

        public string AddBookInfo(string BookName, string BookAuthor, string BookGenre) {
            string result = "";

            var client = new RestClient("https://localhost:44316/api/Book/PostBookInfo?name="+ BookName + "&authorName="+ BookAuthor + "&genre="+ BookGenre + "");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            IRestResponse response = client.Execute(request);

            return result;
        }

        public string DeleteBookInfo(string BookId)
        {
            string result = "";

            var client = new RestClient("https://localhost:44316/api/Book/DeleteBookInfo?id="+ BookId + "");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            IRestResponse response = client.Execute(request);

            return result;
        }


        public string UpdateBookInfo(string BookId, string BookName, string BookAuthor, string BookGenre)
        {
            string result = "";

            var client = new RestClient("https://localhost:44316/api/Book/UpdateBookInfo?id="+ BookId + "&name="+ BookName + "&authorName="+ BookAuthor + "&genre="+ BookGenre + "");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            IRestResponse response = client.Execute(request);

            return result;
        }

    }
}
