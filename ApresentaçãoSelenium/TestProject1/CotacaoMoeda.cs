using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject2
{
    public class CotacaoMoeda
    {
        [Fact]
        public void Cotacao_Euro()
        {
            IWebDriver driver = new ChromeDriver();
           
            driver.Navigate().GoToUrl("https://www.google.com");

            driver.FindElement(By.Id("APjFqb")).SendKeys("Cotação euro");

            driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[4]/center/input[1]")).Click();

            //var cotacao = driver.FindElement(By.XPath("/html/body/div[6]/div/div[9]/div/div[2]/div[2]/div/div/div[1]/div/block-component/div/div[1]/div/div/div/div[1]/div/div/div/div/div/div/div/div/div/div/div[3]/div[1]/div[1]/div[2]/span[1]")).Text;

            driver.Close();
        }

    }
}
