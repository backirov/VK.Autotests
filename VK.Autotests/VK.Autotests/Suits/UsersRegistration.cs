using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Newtonsoft.Json.Linq;

namespace VK.Autotests.Suits
{
    [TestFixture]
    class UsersRegistration
    {
        [TestCase]
        public void User_registration_successed()
        {
            var response = new Requests.UserRegistration().Sign_Up_Success();
            Assert.NotNull(response);//доделать проверку
        }

        [TestCase]
        public void User_registration_failed()
        {
            var response = new Requests.UserRegistration().Sign_Up_Failed();
            var parsedContent = JObject.Parse(response.Content);
            Assert.AreEqual("100", parsedContent["error"]["error_code"]);
        }
    }
}
