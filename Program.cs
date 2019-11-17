using System;
using System.Net;
namespace HttpRequestsWithCSharp
{
    class Program
    {
        

        
        public CookieContainer CookieContainer{get;set;}

        static void Main(string[] args)
        {
            BaseLoginModel loginModel = new BaseLoginModel(){
                UserName = "test",
                Password = "123"
            };
            Program pr = new Program();

            BaseLoginModel newModel = loginModel;
            pr.TestObject(newModel);






            Console.WriteLine(loginModel.UserName);
            Console.WriteLine(loginModel.Password);
        }



        public void TestObject(BaseLoginModel model)
        {
            model.UserName = "NewTest";
            model.Password = "NewPass";

        }
    }
}
