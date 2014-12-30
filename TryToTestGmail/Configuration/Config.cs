using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configuration
{
    public class Config
    {
        #region public methods
        public static BrowserType ReadBrowserTypeFromConfig()
        {
            switch (GetProjectConfig("Browser"))
            {
                case "IE":
                    return BrowserType.IEXPLORER;
                case "CHROME":
                    return BrowserType.CHROME;
                default:
                    return BrowserType.FIREFOX;
            }
        } 
        #endregion
        #region private methods
        private static string GetProjectConfig(string key)
        {
            return System.Configuration.ConfigurationManager.AppSettings[key];
        } 
        #endregion
    }
}