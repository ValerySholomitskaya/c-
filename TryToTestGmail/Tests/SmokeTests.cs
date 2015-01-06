using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Firefox;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Steps;
using NUnit.Framework;
using Utils;

namespace Tests
{
    [TestFixture]
    public class SmokeTests
    {
        private Steps.Step steps = new Steps.Step();
        private const string FIRSTUSERNAME = "trytotestgmi1@gmail.com";
        private const string FIRSTPASSWORD = "TryToTest";
        private const string SECONDUSERNAME = "trytotestgmai1@gmail.com";
        private const string SECONDPASSWORD = "TryToTest";
        private const string THIRDUSERNAME = "trytotestgmai12@gmail.com";
        private const string THIRDPASSWORD = "TryToTest";

        [SetUp]
        public void Init()
        {
            steps.InitBrowser();
        }
        [TearDown]
        public void Cleanup()
        {
            steps.CleanCookie();
            steps.CloseBrowser();
        }
        /*
        [Test]
        public void OneCanLoginAndLogoutGmail()
        {
            steps.LoginGmail(FIRSTUSERNAME, FIRSTPASSWORD);
            steps.LogoutGmail();
        }

        [Test]
        public void TryToSentNewSpamLetter()
        {
            steps.LoginGmail(FIRSTUSERNAME, FIRSTPASSWORD);
            steps.SendMessage(SECONDUSERNAME, Utils.RandomString.GetRandomString(5), Utils.RandomString.GetRandomString(5));         
            steps.LogoutGmail();
            steps.CleanCookie();
            steps.LoginGmail(SECONDUSERNAME, SECONDPASSWORD);
            steps.MarkNewLetterAsSpam();
            steps.LogoutGmail();
            steps.CleanCookie();
            steps.LoginGmail(FIRSTUSERNAME, FIRSTPASSWORD);
            steps.SendMessage(SECONDUSERNAME, Utils.RandomString.GetRandomString(5), Utils.RandomString.GetRandomString(5));
            steps.LogoutGmail();
            steps.CleanCookie();
            steps.LoginGmail(SECONDUSERNAME, SECONDPASSWORD);
            steps.GoToSpamBox();
            NUnit.Framework.Assert.IsTrue(steps.NewLetterIsPresent());
        }
       */
        [Test]
        public void TestForwardingFunction()
        {
            steps.LoginGmail(SECONDUSERNAME, SECONDPASSWORD);
            steps.AddForwardingAdress(THIRDUSERNAME);
            steps.LogoutGmail();
            steps.CleanCookie();
            steps.LoginGmail(THIRDUSERNAME, THIRDPASSWORD);
            steps.ConfirmAddToForwardList(SECONDUSERNAME);
            steps.CleanCookie();
            steps.CloseBrowser();
            steps.InitBrowser();
            steps.LoginGmail(SECONDUSERNAME, SECONDPASSWORD);
            steps.GoToForwardingMenu();
            steps.SetUpForward();
        }

    }
}






