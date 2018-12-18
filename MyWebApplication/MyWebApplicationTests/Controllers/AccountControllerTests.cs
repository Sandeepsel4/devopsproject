using Autofac.Extras.Moq;
using NUnit.Framework;
using MyWebApplication.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApplication.Controllers.Tests
{
    [TestFixture()]
    public class AccountControllerTests
    {
        [Test()]
        public void AccountControllerTest()
        {

            // AccountController controoler = new AccountController(auserManager,signInManager);

            
        }

        [Test()]
        public void AccountControllerTest1()
        {

        }

        [Test()]
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

        [Test()]
        public void LoginTest()
        {

        }

        [Test()]
        public void LoginTest1()
        {

        }

        [Test()]
        public void VerifyCodeTest()
        {

        }

        [Test()]
        public void VerifyCodeTest1()
        {

        }

        [Test()]
        public void RegisterTest()
        {

        }

        [Test()]
        public void RegisterTest1()
        {

        }

        [Test()]
        public void ConfirmEmailTest()
        {

        }

        [Test()]
        public void ForgotPasswordTest()
        {

        }

        [Test()]
        public void ForgotPasswordTest1()
        {

        }

        [Test()]
        public void ForgotPasswordConfirmationTest()
        {

        }

        [Test()]
        public void ResetPasswordTest()
        {

        }

        [Test()]
        public void ResetPasswordTest1()
        {

        }

        [Test()]
        public void ResetPasswordConfirmationTest()
        {

        }

        [Test()]
        public void ExternalLoginTest()
        {

        }

        [Test()]
        public void SendCodeTest()
        {

        }

        [Test()]
        public void SendCodeTest1()
        {

        }

        [Test()]
        public void ExternalLoginCallbackTest()
        {

        }

        [Test()]
        public void ExternalLoginConfirmationTest()
        {

        }

        [Test()]
        public void LogOffTest()
        {

        }

        [Test()]
        public void ExternalLoginFailureTest()
        {

        }
    }
}