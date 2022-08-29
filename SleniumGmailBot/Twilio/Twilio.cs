using System.Configuration;
using Twilio;

namespace SleniumGmailBot.Twilio
{
    public class Twilio
    {
        private readonly IterateEmails getEmails;
        public Twilio(IterateEmails _getEmails)
        {
            getEmails = _getEmails;
        }
        string accountSid = ConfigurationManager.AppSettings["TwilioAccountSid"];
        string accountAuthToken = ConfigurationManager.AppSettings["TwilioAccountAuthToken"];

        public void SendMessage()
        {
            TwilioClient.Init("", "");
        }

    }
}
