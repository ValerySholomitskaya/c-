using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pages
{
    public class SendMessage
    {

        #region private members
        [FindsBy(How = How.XPath, Using = "//div[@class='T-I J-J5-Ji T-I-KE L3']")]
        private IWebElement createMail;

        [FindsBy(How = How.XPath, Using = "//textarea[@class='vO']")]
        private IWebElement toWhomSent;

        [FindsBy(How = How.XPath, Using = "//input[@class='aoT']")]
        private IWebElement theme;

        [FindsBy(How = How.XPath, Using = "//div[@class='Am Al editable LW-avf']")]
        private IWebElement message;

        [FindsBy(How = How.XPath, Using = "//div[@class='T-I J-J5-Ji aoO T-I-atl L3']")]
        private IWebElement sendMessage;

        private IWebDriver driver; 
        #endregion

        #region public methods
        public SendMessage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void CreateMail(string toUser, string someTheme, string someMessage)
        {
            createMail.Click();
            toWhomSent.SendKeys(toUser);
            theme.SendKeys(someTheme);
            message.SendKeys(someMessage);
            sendMessage.Click();
        } 
        #endregion
    }
}