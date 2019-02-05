using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace VK.Autotests.Utilities
{
    public static class Clients
    {
        public static RestClient VKClient { get; } = new RestClient("https://api.vk.com/method")
        {
            FollowRedirects = true,
            CookieContainer = new CookieContainer()
        };

        static Clients()
        {
            VKClient.AddDefaultHeader("Accept", "*/*");
            VKClient.AddDefaultHeader("Accept-Encoding", "gzip, deflate, br");
        }
    }
}
