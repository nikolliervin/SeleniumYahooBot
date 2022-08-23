using OpenQA.Selenium;

namespace SleniumGmailBot.WebElements
{
    public class WebElements
    {
        public By userName => By.XPath("//*[@id='identifierId']");

        public By nextButton => By.XPath("//*[@id='identifierNext']/div/button");
    }
}
