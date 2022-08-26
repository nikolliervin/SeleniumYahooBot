using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SleniumYahooBot
{
    public class SeleniumYahooBotWithTwilio
    {

        public static void Main(string[] args)
        {

            IWebDriver driver = new ChromeDriver();
            Steps.Steps steps = new Steps.Steps();

            steps.LandOnYahoo(driver, steps.URL);
            steps.Login(driver);
            steps.GoToMail(driver);
            steps.GetTheEmailOfIndex(driver, 3);







        }
    }
}
