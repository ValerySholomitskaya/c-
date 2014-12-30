using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;
using Configuration;


namespace Driver
{
    public class DriverInstance
    {
        #region private members
        private static IWebDriver driver;
        #endregion
        #region public methods
        public static IWebDriver GetInstance()
        {
            if (driver == null)
            {
                driver = CreateDriver();
                driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
                driver.Manage().Window.Maximize();
            }
            return driver;
        }
        public static void CloseBrowser()
        {
            driver.Close();
            driver = null;
        }
        #endregion
        #region private methods
        private static IWebDriver CreateDriver()
        {
            IWebDriver driver;
            switch (Config.ReadBrowserTypeFromConfig())
            {
                case BrowserType.IEXPLORER:
                    driver = new InternetExplorerDriver();
                    break;
                case BrowserType.CHROME:
                    driver = new ChromeDriver();
                    break;
                default:
                    driver = new FirefoxDriver();
                    break;
            }
            return driver;
        }
        #endregion

    }
}