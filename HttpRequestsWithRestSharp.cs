using System;
using System.Net;
using System.IO;
using System.Text;
using HttpRequestsWithCSharp.Helpers;
using RestSharp;

namespace HttpRequestsWithCSharp
{
    public static class HttpRequestsWithRestSharp
    {
        public static RestClient client {get;set;} = new RestClient("http://testing-ground.scraping.pro/");

        public static IRestResponse ExecutePost(string preffix, CookieContainer cookies)
        {
            RestRequest request = new RestRequest(preffix, Method.POST);
            request.AddHeader("Content-type", "application/x-www-form-urlencoded");
            request.AddHeader("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8");
            request.AddParameter("usr", "admin");
            request.AddParameter("pwd", "12345");
            var response = client.Execute(request);
            return response;
            superchanges
        }
    }
}