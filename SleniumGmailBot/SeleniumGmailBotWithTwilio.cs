using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SleniumGmailBot;
using System.Collections.Generic;

namespace SleniumYahooBot
{
    public class SeleniumYahooBotWithTwilio
    {

        public static void Main(string[] args)
        {

            IWebDriver driver = new ChromeDriver();
            Steps.Steps steps = new Steps.Steps();
            IterateEmails iterate = new IterateEmails();

            steps.LandOnYahoo(driver, steps.URL);
            steps.Login(driver);
            steps.GoToMail(driver);
            steps.GetTheEmailOfIndex(driver, 3);

            List<string> emails = new List<string>();
            emails = iterate.IterateThroughEmails(driver);









        }
    }
}
