﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Driver;
using log4net;
using Utils;



namespace Steps
{
    public class Step
    {
        IWebDriver driver;
        private static readonly ILog logger = LogManager.GetLogger(typeof(Step));

        #region public methods
        public void InitBrowser()
        {
            logger.Info("init browser");
            driver = DriverInstance.GetInstance();
        }

        public void CloseBrowser()
        {
            logger.Info("close browser");
            DriverInstance.CloseBrowser();
        }

        public void LoginGmail(string username, string password)
        {
            logger.Info("Log in to gmail");
            Pages.LoginPage loginPage = new Pages.LoginPage(driver);
            loginPage.OpenPage();
            loginPage.Login(username, password);
        }

        public void LogoutGmail()
        {
            logger.Info("LogOut from gmail");
            Pages.MainGmailPage logOut = new Pages.MainGmailPage(driver);
            Utils.Alerts alert = new Utils.Alerts(driver);
            logOut.LogOut();
            alert.AcceptAllert();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
        }


        public void AddForwardingAdress(string to)
        {
            logger.Info("Lets go forwarding menu");
            Pages.SettingsPage settings = new Pages.SettingsPage(driver);
            settings.AddForwardAdress(to);
        }

        public void CleanCookie()
        {
            logger.Info("cookies are cleaned");
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().Refresh();
        }

        public void SendMessage(string to, string theme, string message)
        {
            logger.Info("message sent");
            Pages.SendMessage sendMessage = new Pages.SendMessage(driver);
            sendMessage.CreateMail(to, theme, message);
        }

        public void MarkKnownLetterAsSpam(string somethingInTheLetter)
        {
            logger.Info("message in spam");
            Pages.MainGmailPage addToSpam = new Pages.MainGmailPage(driver);
            addToSpam.AddToSpamKnownLetter(somethingInTheLetter);
        }

        public void MarkNewLetterAsSpam()
        {
            logger.Info("new message in spam");
            Pages.MainGmailPage addToSpam = new Pages.MainGmailPage(driver);
            addToSpam.AddToSpamNewLetter();
        }

        public void GoToSpamBox()
        {
            logger.Info("we are in spam box");
            Pages.MainGmailPage goToSpam = new Pages.MainGmailPage(driver);
            goToSpam.GoToSpamPage();
        }

        public bool NewLetterIsPresent()
        {
            Pages.MainGmailPage newLetter = new Pages.MainGmailPage(driver);
           return newLetter.NewLetter();
        }
        public void ConfirmForwarding(string theme)
        {
            Pages.MainGmailPage confirm = new Pages.MainGmailPage(driver);
            confirm.GetLetter(theme);
        }
        public void GoToForwardingMenu()
        {
            Pages.SettingsPage settings = new Pages.SettingsPage(driver);
            settings.GoToForwardingMenu();
        }
        #endregion
       
    }
}


