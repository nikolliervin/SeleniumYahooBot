using OpenQA.Selenium;

namespace SleniumGmailBot.WebElements
{
    public class WebElements
    {
        public By LoginUsernameField => By.XPath("//*[@id='login-username']");

        public By LoginNextButton => By.XPath("//*[@id='login-signin']");

        public By LoginPasswordField => By.XPath("//*[@id='login-passwd']");

        public By MailButton => By.XPath("//*[@id='ybarMailLink']");
        //public By MailButton => By.XPath("//*[@id='ybar-inner-wrap']/div[3]/div/div[3]/div[3]");


        public By YahooMails(int index) => By.XPath($"//*[@id='mail-app-component']/div/div/div/div[2]/div/div/div[3]/div/div[1]/ul/li[{index}]/a");


    }
}
