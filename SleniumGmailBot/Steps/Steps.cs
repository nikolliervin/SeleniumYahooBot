﻿using OpenQA.Selenium;
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
            var username = ConfigurationManager.AppSettings.Get("username");
            driver.FindElement(userName).SendKeys(username);
        }
    }
}
