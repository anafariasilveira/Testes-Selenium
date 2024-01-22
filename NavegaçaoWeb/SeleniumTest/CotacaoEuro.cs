using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTest
{
    public class CotacaoEuro
    {
        [Fact]
        public void Cotacao_Euro()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.google.com/");

            driver.FindElement(By.Id("APjFqb")).SendKeys("Cotação Euro");

            driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[2]/div[4]/div[7]/center/input[1]")).Click();

            var cotacao = driver.FindElement(By.XPath("//*[@id=\"knowledge-currency__updatable-data-column\"]/div[1]/div[2]/span[1]")).Text;

            Console.WriteLine(cotacao);

        }
    }
}