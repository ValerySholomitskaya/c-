﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pages
{
    public class MainGmailPage 
    {
        #region private members
        [FindsBy(How = How.XPath, Using = "//a[@class='gb_C gb_da gb_h gb_9']")]
        private IWebElement linkLogOutUser;

        [FindsBy(How = How.XPath, Using = "//a[@class='gb_2b gb_9b gb_X']")]
        private IWebElement buttonLogOut;

        [FindsBy(How = How.XPath, Using = "//tr[@class='zA zE']")]
        private IWebElement newLetter;

        [FindsBy(How = How.XPath, Using = "//img[@class='hA T-I-J3']")]
        private IWebElement letterMenu;

        [FindsBy(How = How.XPath, Using = "//div[@class='cj'][@act='9']")]
        private IWebElement reportSpamButton;

        [FindsBy(How = How.XPath, Using = "//button[@class='gbqfb']/span")]
        private IWebElement searchButton;

        [FindsBy(How = How.XPath, Using = "//input[@class='gbqfif']")]
        private IWebElement searchField;

        [FindsBy(How = How.XPath, Using = "//div[@class='T-Jo-auh']")]
        private IWebElement buttonForAllLetters;

        [FindsBy(How = How.XPath, Using = "//div[@class='asl T-I-J3 J-J5-Ji']")]
        private IWebElement toSpam;

        [FindsBy(How = How.XPath, Using = "//a[@target='_blank']")]
        private IWebElement toConfirm;

        [FindsBy(How = How.XPath, Using ="//div[@class='a3s']/a[4]")]
        private IWebElement aConfirmAddToForwardListLink;

        private IWebDriver driver;

        #endregion
        #region public methods
        public MainGmailPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void LogOut()
        {
            linkLogOutUser.Click();
            buttonLogOut.Click();
        }

        public void AddToSpamNewLetter()
        {
            Utils.WaitingElement waiting = new Utils.WaitingElement(driver);
            waiting.WaitElement(newLetter);
            newLetter.Click();
            letterMenu.Click();
            reportSpamButton.Click();
        }

        public void AddToSpamKnownLetter(string somethingInTheLetter)
        {
            GetLetter(somethingInTheLetter);
            toSpam.Click();
        }

        public void GoToSpamPage()
        {
            searchField.SendKeys("in:spam");
            searchButton.Click();
        }

        public void GetLetter(string somethingInTheLetter)
        {
            searchField.SendKeys(somethingInTheLetter);
            searchButton.Click();
            buttonForAllLetters.Click();
        }

        public void OpensAndConfirm(String subject)
        {
            IWebElement element = driver.FindElement(By.XPath("//span[contains(text(), '" + subject + "')]"));
            if (Utils.WaitingElement.IsWebElementPresent(driver, element))
            {
                element.Click();
            }
            aConfirmAddToForwardListLink.Click();
        }

        public bool NewLetter()
        {
            Utils.WaitingElement waiting = new Utils.WaitingElement(driver);
            DateTime start = DateTime.Now;
            TimeSpan sp = DateTime.Now - start;
            if (sp.Minutes < 5)
            {
                while (newLetter.Displayed != true)
                {
                    driver.Navigate().Refresh();
                    driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
                }
            }
            return newLetter.Displayed;
        }

        #endregion
    }
}