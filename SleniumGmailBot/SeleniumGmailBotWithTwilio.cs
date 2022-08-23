using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SleniumGmailBot
{
    public class SeleniumGmailBotWithTwilio
    {

        public static void Main(string[] args)
        {

            IWebDriver driver = new ChromeDriver();
            Steps.Steps steps = new Steps.Steps();
            steps.LandOnGmail(driver, steps.URL);






        }
    }
}
