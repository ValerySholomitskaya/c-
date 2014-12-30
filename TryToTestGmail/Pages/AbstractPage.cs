﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pages
{
    public abstract class AbstractPage
    {
        #region public methods
        public abstract void OpenPage();
        public bool IsElementPresent(By locator)
        {
            return Driver.DriverInstance.GetInstance().FindElements(locator).Count > 0;
        } 
        #endregion
    }
}