using System.Configuration;

namespace SleniumGmailBot.Twilio
{
    public class Twilio
    {
        string accountSid = ConfigurationManager.AppSettings["TwilioAccountSid"];
        string accountAuthToken = ConfigurationManager.AppSettings["TwilioAccountAuthToken"];

        public void SendMessage()
        {

        }

    }
}
