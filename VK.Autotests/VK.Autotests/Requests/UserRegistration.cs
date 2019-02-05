using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VK.Autotests.Utilities;
using RestSharp;

namespace VK.Autotests.Requests
{
    public class UserRegistration
    {
        public IRestResponse Sign_Up_Success()
        {
            var request = new RestRequest("auth.signup", Method.POST);
            request.AddQueryParameter("phone", "87945612365");
            request.AddQueryParameter("first_name", "Ivan");
            request.AddQueryParameter("last_name", "Ivanov");
            request.AddQueryParameter("birthday", "01.01.2000");
            request.AddQueryParameter("client_id", "1904585");
            request.AddQueryParameter("client_secret", "cUIEOsswC2SyTMYAh7dy");
            request.AddQueryParameter("sex", "2");
            request.AddQueryParameter("password", "123123Aa");
            request.AddQueryParameter("test_mode", "1");
            request.AddQueryParameter("v", "5.92");

            var response = Clients.VKClient.Execute(request);

            return response;
        }

        public IRestResponse Sign_Up_Failed()
        {
            var request = new RestRequest("auth.signup", Method.POST);
            request.AddQueryParameter("first_name", "Ivan");
            request.AddQueryParameter("last_name", "Ivanov");
            request.AddQueryParameter("birthday", "01.01.2000");
            request.AddQueryParameter("client_id", "1904585");
            request.AddQueryParameter("client_secret", "cUIEOsswC2SyTMYAh7dy");
            request.AddQueryParameter("sex", "2");
            request.AddQueryParameter("password", "123123Aa");
            request.AddQueryParameter("test_mode", "1");
            request.AddQueryParameter("v", "5.92");

            var response = Clients.VKClient.Execute(request);

            return response;
        }
    }
}
