using System;
using System.Net;
using System.IO;

namespace HttpRequestsWithCSharp
{
    public static class HttpRequests
    {
        public static string Get(string url, CookieContainer cookies)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.CookieContainer = cookies;
            
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            cookies.Add(response.Cookies);

            string pageSource;

            using (StreamReader sr = new StreamReader(response.GetResponseStream()))
            {
                pageSource = sr.ReadToEnd();
            }
            return pageSource;
        }

        public static string Post(string url, CookieContainer cookies, BaseLoginModel model)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.CookieContainer = cookies;
            request.ContentType = "application/x-www-form-urlencoded";
            request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
            Stream postStream = request.GetRequestStream();
            



            return new string("asda");
        }
    }
}
