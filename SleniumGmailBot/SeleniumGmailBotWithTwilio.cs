using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SleniumGmailBot
{
    public class SeleniumGmailBotWithTwilio
    {
        private readonly Steps steps;
        public SeleniumGmailBotWithTwilio(Steps _steps)
        {
            steps = _steps;
        }
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();


        }
    }
}
