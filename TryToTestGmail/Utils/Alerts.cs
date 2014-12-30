using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
   public class Alerts
    {
        #region private members
        private IWebDriver driver; 
        #endregion

        #region constructor
        public Alerts(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        } 
        #endregion

        #region public methods
        public void AcceptAllert()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                if (driver.SwitchTo().Alert() != null)
                {
                    alert.Accept();
                }
            }
            catch (Exception e) { }
        } 
        #endregion
    }
}