using OpenQA.Selenium;
using SleniumGmailBot.WebElements;
using System.Configuration;

namespace SleniumYahooBot.Steps
{
    public class Steps : WebElements
    {
        public string URL = ConfigurationManager.AppSettings["url"];

        public void LandOnYahoo(IWebDriver driver, string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void Login(IWebDriver driver)
        {
            var username = ConfigurationManager.AppSettings["username"];
            var password = ConfigurationManager.AppSettings["password"];




        }


    }
}
