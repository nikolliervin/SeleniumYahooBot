using OpenQA.Selenium;
using System.Configuration;


namespace SleniumGmailBot.Steps
{
    public class Steps : WebElements.WebElements
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

        }
    }
}
