using OpenQA.Selenium;

namespace SleniumGmailBot.WebElements
{
    public class WebElements
    {
        public By userName => By.XPath("//*[@id='identifierId']");

        public By nextButton => By.XPath("//*[@id='identifierNext']/div/button");

        public By gmailPassword => By.XPath("//*[@id='password']/div[1]/div/div[1]/input");

        public By loginWithGoogleButton => By.XPath("//*[@id='openid-buttons']/button[1]");
    }
}
