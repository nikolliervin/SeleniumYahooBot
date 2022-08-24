using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SleniumGmailBot.WebElements;
using System.Collections.Generic;
using System.Configuration;

namespace SleniumYahooBot.Steps
{
    public class Steps : WebElements
    {
        public string URL = "https://gmail.com";

        public void LandOnGmail(IWebDriver driver, string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void Login(IWebDriver driver)
        {
            var username = ConfigurationManager.AppSettings["username"];
            var password = ConfigurationManager.AppSettings["password"];
            driver.FindElement(userName).SendKeys(username);
            driver.FindElement(nextButton).Click();



        }

        public void AuthenticateFromStackOverflowExchange(IWebDriver driver)
        {
            var options = new ChromeOptions();
            options.AddExcludedArguments(new List<string>() { "enable-automation" });

            var stackOverflowURL = ConfigurationManager.AppSettings["stackOverflow"];
            var username = ConfigurationManager.AppSettings["username"];
            var password = ConfigurationManager.AppSettings["password"];

            driver.Navigate().GoToUrl(stackOverflowURL);
            driver.FindElement(loginWithGoogleButton).Click();

            driver.FindElement(userName).SendKeys(username);
            driver.FindElement(nextButton).Click();
            driver.FindElement(gmailPassword).SendKeys(password);
        }
    }
}
