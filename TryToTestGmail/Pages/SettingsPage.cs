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
    public class SettingsPage
    {
        #region private members

        private const string BASE_URL = "https://mail.google.com/mail/#settings/fwdandpop";

        [FindsBy(How = How.XPath, Using = "//div[@class='aos T-I-J3 J-J5-Ji']")]
        private IWebElement linkSettings;

        [FindsBy(How = How.XPath, Using = "//div[@class='J-N aMS']")]
        private IWebElement buttonSettings;

        [FindsBy(How = How.XPath, Using = "//input[@type='button']")]
        private IWebElement linkToAddAdressInForwardingMenu;

        [FindsBy(How = How.XPath, Using = "//input[@type='text'][@size='48']")]
        private IWebElement WriteAdressInForwardingMenu;

        [FindsBy(How = How.XPath, Using = "//button[@class='J-at1-auR']")]
        private IWebElement ButtonToSuggestAdressInForwardingMenu;

        [FindsBy(How = How.XPath, Using = "//input[@type='submit']")]
        private IWebElement ButtonToAgreeWithAdressInForwardingMenu;

        [FindsBy(How = How.XPath, Using = "//button[@class='J-at1-auR']")]
        private IWebElement ButtonToAgree;

        [FindsBy(How = How.XPath, Using = "//button[@class='J-at1-auR']")]
        private IWebElement ConfirmForwarding;

        [FindsBy(How = How.XPath, Using ="//div[@class='nH Tv1JD']//*/button[@guidedhelpid='save_changes_button']")]
        private IWebElement buttonSaveChanges;

        private IWebDriver driver;

        #endregion

        #region public methods
        public SettingsPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void GoToSettings()
        {
            linkSettings.Click();
            buttonSettings.Click();
        }

        public void GoToForwardingMenu()
        {
            driver.Navigate().GoToUrl(BASE_URL);
        }

        public void EnableForward()
        {
            GoToForwardingMenu();
            linkToAddAdressInForwardingMenu.Click();
            IReadOnlyCollection<IWebElement> radioButton = driver.FindElements(By.XPath("//input[@name='sx_em']"));
            bool state = false;
            state = radioButton.ElementAt(0).Selected;
            if (state)
            {
                radioButton.ElementAt(1).Click();
            }
            else
            {
                radioButton.ElementAt(0).Click();
            }
        }

        public void SaveSettings()
        {
            GoToForwardingMenu();
            linkToAddAdressInForwardingMenu.Click();
            Utils.WaitingElement waiting = new Utils.WaitingElement(driver);
            waiting.WaitElement(buttonSaveChanges);
            buttonSaveChanges.Click();
        }

        public void AddForwardAdress(string address)
        {
            Utils.Alerts alert = new Utils.Alerts(driver);
            GoToForwardingMenu();
            linkToAddAdressInForwardingMenu.Click();
            WriteAdressInForwardingMenu.SendKeys(address);
            ButtonToSuggestAdressInForwardingMenu.Click();
            string BaseWindow = driver.CurrentWindowHandle; 
            driver.SwitchTo().Frame(driver.FindElement(By.ClassName("ds")));
            ButtonToAgreeWithAdressInForwardingMenu.Click();
            driver.SwitchTo().Window(BaseWindow);
            ButtonToAgree.Click();
            alert.AcceptAllert();

        }
        #endregion
    }
}