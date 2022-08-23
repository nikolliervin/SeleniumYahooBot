using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SleniumGmailBot
{
    public class SeleniumGmailBotWithTwilio
    {
        public readonly Steps.Steps steps;
        public SeleniumGmailBotWithTwilio(Steps.Steps _steps)
        {
            steps = _steps;
        }

        void Main(string[] args)
        {

            IWebDriver driver = new ChromeDriver();

            steps.LandOnGmail(driver, steps.URL);






        }
    }
}
