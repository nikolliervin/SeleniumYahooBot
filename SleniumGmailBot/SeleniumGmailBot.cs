using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SleniumGmailBot
{
    public class SeleniumGmailBot
    {
        private readonly Steps steps;
        public SeleniumGmailBot(Steps _steps)
        {
            steps = _steps;
        }
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();


        }
    }
}
