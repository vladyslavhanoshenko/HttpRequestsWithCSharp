using System;
using System.Net;
using System.IO;
using System.Text;
using HttpRequestsWithCSharp.Helpers;

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

        public static HttpWebResponse Post(string url, CookieContainer cookies, BaseLoginModel model)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.CookieContainer = cookies;
            request.ContentType = "application/x-www-form-urlencoded";
            request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
            Stream postStream = request.GetRequestStream();
            byte[] postBytes = Encoding.ASCII.GetBytes(DataTransformationHelper.CreateStringForPostRequest(model));
            postStream.Write(postBytes, 0, postBytes.Length);
            postStream.Dispose();

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            cookies.Add(response.Cookies);
            var test1 = response.ResponseUri;
            var test = (int)response.StatusCode;

            StreamReader sr = new StreamReader(response.GetResponseStream());
            string pageSource = sr.ReadToEnd();
            sr.Dispose();

            if (response.ResponseUri.PathAndQuery.Equals("/login?mode=welcome"))
                return response;
            else
                throw new Exception("reponse uri is empty");
        }
    }
}
