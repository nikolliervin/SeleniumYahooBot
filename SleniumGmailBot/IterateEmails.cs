using OpenQA.Selenium;
using System.Collections.Generic;

namespace SleniumGmailBot
{
    public class IterateEmails : WebElements.WebElements
    {

        public List<string> IterateThroughEmails(IWebDriver driver)
        {

            List<string> emails = new List<string>();

            for (int i = 3; i <= 5; i++)
            {
                emails.Add(driver.FindElement(YahooMails(i)).ToString());
            }

            return emails;

        }

        public List<string> EmailsCleanedUp(List<string> strings)
        {

        }

    }
}
