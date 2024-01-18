using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject1
{
    public class GitHubLinkedIn
    {
        [Fact]
        public void OpenGitHub()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://github.com/anafariasilveira");

            Assert.Contains("anafariasilveira", driver.Title);
        }
        [Fact]
        public void OpenLinkedIn()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.linkedin.com/in/anapaulacfaria/");

            Assert.Contains("Ana Paula Silveira", driver.Title);
        }
    }
}