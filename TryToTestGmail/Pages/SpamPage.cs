﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace Pages
{
    public class SpamPage
    {
        #region private members


        [FindsBy(How = How.XPath, Using = "//tr[@class='zA zE']")]
        private IWebElement spamLetter;

        [FindsBy(How = How.XPath, Using = "//span[@class='go gD']")]
        private IWebElement senderMail;

        [FindsBy(How = How.XPath, Using = "//div[@class='ar6 T-I-J3 J-J5-Ji']")]
        private IWebElement backToSpamButton;

        [FindsBy(How = How.XPath, Using = "//div[@act='T-I J-J5-Ji aFk T-I-ax7   ar7']")]
        private IWebElement notSpamButton;

        private IWebDriver driver;
        #endregion

        #region public methods
        public SpamPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }


        public string GetSpamLetter()
        {
            Utils.WaitingElement waiting = new Utils.WaitingElement(driver);
            waiting.WaitElement(spamLetter);
            spamLetter.Click();
            return senderMail.Text;
        }

        #endregion
    }
}