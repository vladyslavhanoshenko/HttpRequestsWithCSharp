using System;
using System.Net;
namespace HttpRequestsWithCSharp
{
    class Program
    {
        public static CookieContainer CookieContainer { get; set; } = new CookieContainer();
        public static string LoginUrl = "http://testing-ground.scraping.pro/login?mode=login";
        public static string RedirectedUrl = "http://testing-ground.scraping.pro/login?mode=welcome";

        static void Main(string[] args)
        {
            var test = HttpRequestsWithRestSharp.ExecutePost("login?mode=login");
            BaseLoginModel loginModel = new BaseLoginModel();
            HttpRequests.Post(LoginUrl, CookieContainer, loginModel);
        }
    }
}
