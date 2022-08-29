using OpenQA.Selenium.Chrome;
using SleniumGmailBot;
using SleniumGmailBot.Twilio;
using SleniumYahooBot.Steps;
using System.Collections.Generic;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace SeleniumYahooBot
{
    public class SeleniumYahooBotWithTwilio
    {

        public static void Main(string[] args)
        {
            var options = new ChromeOptions();
            options.AddArgument("--headless");
            options.AddArgument("start-maximized");

            ChromeDriver driver = new ChromeDriver(options);
            Steps steps = new Steps();
            IterateEmails iterate = new IterateEmails();
            TwilioConfig twilioConfig = new TwilioConfig(iterate);



            steps.LandOnYahoo(driver, steps.URL);
            steps.Login(driver);
            steps.GoToMail(driver);
            steps.GetTheEmailOfIndex(driver, 3);

            List<string> emails = new List<string>();
            emails = iterate.IterateThroughEmails(driver);

            TwilioClient.Init(twilioConfig.accountSid, twilioConfig.accountAuthToken);

            for (int i = 0; i < emails.Count; i++)
            {
                var message = MessageResource.Create(
                body: $"*You have missed the following Email:*{emails[i]}",
                from: new Twilio.Types.PhoneNumber($"whatsapp:{twilioConfig.TwilioPhoneNumber}"),
                to: new Twilio.Types.PhoneNumber($"whatsapp:{twilioConfig.MyPhoneNumber}")
                );
            }















        }
    }
}
