using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Threading;
using Testimi;


namespace TestimiProjekti
{
    internal class TS4
    {
        Config config = new Config();

        [Test]
        public void TS4_GjobatPersonale()
        {
            config.Hapja("https://ekosova.rks-gov.net/Services");
            Actions actions = new Actions(config.driver);


            IWebElement el = config.driver.FindElement(By.XPath("/html/body/div[2]/section/div[2]/a[6]"));
            actions.MoveToElement(el);
            actions.Perform();
            el.Click();
            config.driver.FindElement(By.XPath("/html/body/div[2]/section/div[2]/div[1]/a")).Click();

        }
    }
}
