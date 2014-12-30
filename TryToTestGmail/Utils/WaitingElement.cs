﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace Utils
{
    public class WaitingElement
    {
        #region private members
        private IWebDriver driver; 
        #endregion

        #region public methods
        public WaitingElement(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public void WaitElement(IWebElement webElement)
        {
            try
            {
                if (webElement.Displayed)
                {
                }
            }
            catch (Exception e)
            {
                if (e is ElementNotVisibleException || e is NoSuchElementException)
                {
                    driver.Navigate().Refresh();
                    driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    WaitElement(webElement);
                    }
                }
            }
        } 
        #endregion
    }



  