using OpenQA.Selenium;
using SleniumGmailBot.WebElements;
using System.Configuration;
using System.Threading;

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
            driver.FindElement(LoginUsernameField).SendKeys(username);
            driver.FindElement(LoginNextButton).Click();
            Thread.Sleep(1000);
            driver.FindElement(LoginPasswordField).SendKeys(password);
            driver.FindElement(LoginNextButton).Click();
            Thread.Sleep(1000);

        }

        public void GoToMail(IWebDriver driver)
        {
            driver.FindElement(MailButton).Click();

        }

        public string GetTheEmailOfIndex(IWebDriver driver, int index)
        {
            Thread.Sleep(1000);
            var email = driver.FindElement(YahooMails(index)).GetAttribute("aria-label");
            return email;
        }


    }
}
