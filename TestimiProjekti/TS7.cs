using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using Testimi;

namespace TestimiProjekti
{
    internal class TS7
    {
        Config config = new Config();
        [Test]
        public void Shumegjuhesia_Shqip()
        {
            config.Hapja("https://my.riinvest.net/Student/Home.aspx");
            IWebElement userInput = config.driver.FindElement(By.XPath("/html/body/div/form/div[3]/div[2]/table/tbody/tr/td[2]/table/tbody/tr/td/div/table/tbody/tr[1]/td/p[2]/input"));
            userInput.Click();
            userInput.SendKeys(TopSecret.MyRiinvestUser);
            IWebElement pwInput = config.driver.FindElement(By.XPath("/html/body/div/form/div[3]/div[2]/table/tbody/tr/td[2]/table/tbody/tr/td/div/table/tbody/tr[2]/td/p[2]/input"));
            pwInput.Click();
            pwInput.SendKeys(TopSecret.MyRiinvestPw);
            config.driver.FindElement(By.XPath("/html/body/div/form/div[3]/div[2]/table/tbody/tr/td[2]/table/tbody/tr/td/div/table/tbody/tr[4]/td/input")).Click();
            string text = config.driver.FindElement(By.XPath("/html/body/form/div[3]/div[4]/div[3]/div/div/table/tbody/tr/td[1]/div/div[2]/div/table/tbody/tr/td[2]/a")).Text;
            if (text == "Programimi mobil dhe cloud")
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }

        }
        [Test]
        public void Shumegjuhesia_Anglisht()
        {
            config.Hapja("https://my.riinvest.net/Student/Home.aspx");
            IWebElement userInput = config.driver.FindElement(By.XPath("/html/body/div/form/div[3]/div[2]/table/tbody/tr/td[2]/table/tbody/tr/td/div/table/tbody/tr[1]/td/p[2]/input"));
            userInput.Click();
            userInput.SendKeys(TopSecret.MyRiinvestUser);
            IWebElement pwInput = config.driver.FindElement(By.XPath("/html/body/div/form/div[3]/div[2]/table/tbody/tr/td[2]/table/tbody/tr/td/div/table/tbody/tr[2]/td/p[2]/input"));
            pwInput.Click();
            pwInput.SendKeys(TopSecret.MyRiinvestPw);
            config.driver.FindElement(By.XPath("/html/body/div/form/div[3]/div[2]/table/tbody/tr/td[2]/table/tbody/tr/td/div/table/tbody/tr[4]/td/input")).Click();
    
                config.driver.FindElement(By.XPath("/html/body/form/div[3]/div[4]/ul/li[1]/input")).Click();
            string text = config.driver.FindElement(By.XPath("/html/body/form/div[3]/div[4]/div[3]/div/div/table/tbody/tr/td[1]/div/div[2]/div/table/tbody/tr/td[2]/a")).Text;
            Thread.Sleep(3000);
            config.TakeScr("TS7_TC2");


            if (text == "Mobile and cloud programming.")
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }

        }
    }
}
