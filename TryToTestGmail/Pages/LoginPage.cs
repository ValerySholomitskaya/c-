using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pages
{
    public class LoginPage : AbstractPage
    {
        #region private members
        private const string BASE_URL = "https://gmail.com/";

        [FindsBy(How = How.Id, Using = "Email")]
        private IWebElement inputLogin;

        [FindsBy(How = How.Id, Using = "Passwd")]
        private IWebElement inputPassword;

        [FindsBy(How = How.Id, Using = "signIn")]
        private IWebElement buttonSubmit;

        private IWebDriver driver; 
        #endregion

        #region public methods
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }
        public override void OpenPage()
        {
            driver.Navigate().GoToUrl(BASE_URL);
            Console.WriteLine("Login Page opened");
        }
        public void Login(string username, string password)
        {
            inputLogin.SendKeys(username);
            inputPassword.SendKeys(password);
            buttonSubmit.Click();
        } 
        #endregion
    }
}













