using System.Configuration;


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

        string TwilioPhoneNumber = ConfigurationManager.AppSettings["TwilioPhoneNumber"];
        string MyPhoneNumber = ConfigurationManager.AppSettings["MyPhoneNumber"];
        public void SendMessage()
        {

        }

    }
}
