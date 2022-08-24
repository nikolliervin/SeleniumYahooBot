using OpenQA.Selenium;

namespace SleniumGmailBot.WebElements
{
    public class WebElements
    {
        public By LoginUsernameField => By.XPath("//*[@id='login-username']");

        public By LoginNextButton => By.XPath("//*[@id='login-signin']");

        public By LoginPasswordField => By.XPath("//*[@id='login-passwd']");

        public By MailButton => By.XPath("//*[@id='ybarMailLink']");


    }
}
