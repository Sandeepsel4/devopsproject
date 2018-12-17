using Autofac.Extras.Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyWebApplication.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApplication.Controllers.Tests
{
    [TestClass()]
    public class AccountControllerTests
    {
        [TestMethod()]
        public void AccountControllerTest()
        {

            // AccountController controoler = new AccountController(auserManager,signInManager);

            
        }

        [TestMethod()]
        public void AccountControllerTest1()
        {

        }

        [TestMethod()]
        public void AuthorizeTest()
        {
            using (var mock = AutoMock.GetLoose())
            {
                // The AutoMock class will inject a mock IDependency
                // into the SystemUnderTest constructor
                var sut = mock.Create<AccountController>();
                sut.Authorize();
            }
        }

        [TestMethod()]
        public void LoginTest()
        {

        }

        [TestMethod()]
        public void LoginTest1()
        {

        }

        [TestMethod()]
        public void VerifyCodeTest()
        {

        }

        [TestMethod()]
        public void VerifyCodeTest1()
        {

        }

        [TestMethod()]
        public void RegisterTest()
        {

        }

        [TestMethod()]
        public void RegisterTest1()
        {

        }

        [TestMethod()]
        public void ConfirmEmailTest()
        {

        }

        [TestMethod()]
        public void ForgotPasswordTest()
        {

        }

        [TestMethod()]
        public void ForgotPasswordTest1()
        {

        }

        [TestMethod()]
        public void ForgotPasswordConfirmationTest()
        {

        }

        [TestMethod()]
        public void ResetPasswordTest()
        {

        }

        [TestMethod()]
        public void ResetPasswordTest1()
        {

        }

        [TestMethod()]
        public void ResetPasswordConfirmationTest()
        {

        }

        [TestMethod()]
        public void ExternalLoginTest()
        {

        }

        [TestMethod()]
        public void SendCodeTest()
        {

        }

        [TestMethod()]
        public void SendCodeTest1()
        {

        }

        [TestMethod()]
        public void ExternalLoginCallbackTest()
        {

        }

        [TestMethod()]
        public void ExternalLoginConfirmationTest()
        {

        }

        [TestMethod()]
        public void LogOffTest()
        {

        }

        [TestMethod()]
        public void ExternalLoginFailureTest()
        {

        }
    }
}