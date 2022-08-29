using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SleniumGmailBot;
using SleniumGmailBot.Twilio;
using System.Collections.Generic;
using Twilio.Rest.Api.V2010.Account;

namespace SleniumYahooBot
{
    public class SeleniumYahooBotWithTwilio
    {

        public static void Main(string[] args)
        {

            IWebDriver driver = new ChromeDriver();
            Steps.Steps steps = new Steps.Steps();
            IterateEmails iterate = new IterateEmails();
            TwilioConfig twilioConfig = new TwilioConfig(iterate);


            steps.LandOnYahoo(driver, steps.URL);
            steps.Login(driver);
            steps.GoToMail(driver);
            steps.GetTheEmailOfIndex(driver, 3);

            List<string> emails = new List<string>();
            emails = iterate.IterateThroughEmails(driver);


            for (int i = 0; i < emails.Count; i++)
            {
                var message = MessageResource.Create(
                body: $"You have missed the following Email:{emails[i]}",
                from: new Twilio.Types.PhoneNumber($"whatsapp:{twilioConfig.TwilioPhoneNumber}"),
                to: new Twilio.Types.PhoneNumber($"whatsapp:{twilioConfig.MyPhoneNumber}")
                );
            }















        }
    }
}
