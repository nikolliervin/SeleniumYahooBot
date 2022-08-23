namespace SleniumGmailBot.Steps
{
    public class Steps
    {
        public string URL = "https://gmail.com";

        public void LandOnGmail(IWebDriver driver, string url)
        {
            driver.Navigate().GoToUrl(url);
        }
    }
}
