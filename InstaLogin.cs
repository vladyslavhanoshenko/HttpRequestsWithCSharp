using System;
using System.Net;
using System.IO;
using System.Text;
using HttpRequestsWithCSharp.Helpers;
using RestSharp;

namespace HttpRequestsWithCSharp
{
    public static class InstaLogin
    {
        public static string InstaHomeUrl{get;set;}="https://www.instagram.com/";
        public static string InstaLoginIrl{get;set;}="";

        public static CookieContainer Cookies{get;set;} = new CookieContainer();

        
        public static void Login()
        {
            InstaLoginModel test = new InstaLoginModel();
            HttpRequests.Get()
        }
    }
}
