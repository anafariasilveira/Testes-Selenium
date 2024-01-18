using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace GitHub_LinkedIn
{
    public class GitHub
    {
        private readonly IWebDriver driver;

        public GitHub()
        {
            driver = new ChromeDriver();
        }
        public void OpenGitHub()
        {
            driver.Navigate().GoToUrl("https://github.com/anafariasilveira");
        }
    }
}
