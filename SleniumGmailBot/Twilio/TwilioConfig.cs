using System.Configuration;


namespace SleniumGmailBot.Twilio
{
    public class TwilioConfig
    {
        private readonly IterateEmails getEmails;
        public TwilioConfig(IterateEmails _getEmails)
        {
            getEmails = _getEmails;
        }
        public string accountSid = ConfigurationManager.AppSettings["TwilioAccountSid"];
        public string accountAuthToken = ConfigurationManager.AppSettings["TwilioAccountAuthToken"];

        public string TwilioPhoneNumber = ConfigurationManager.AppSettings["TwilioPhoneNumber"];
        public string MyPhoneNumber = ConfigurationManager.AppSettings["MyPhoneNumber"];


    }
}
