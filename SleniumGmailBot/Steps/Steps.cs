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
            Configuration login = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var username = login.AppSettings.Settings["Username"];
            driver.FindElement(userName).SendKeys(username.ToString());
        }
    }
}
