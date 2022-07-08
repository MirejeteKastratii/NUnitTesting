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
            config.Hapja("https://ekosova.rks-gov.net/Service/9");
            Actions actions = new Actions(config.driver);
            config.driver.FindElement(By.XPath("/html/body/div[2]/section/div[2]/div[1]")).Click();
            IWebElement inpUser = config.driver.FindElement(By.XPath("/html/body/div[2]/section/form/div[1]/input"));
            inpUser.Click();
            inpUser.SendKeys(TopSecret.eKsUser);
            IWebElement inpPw = config.driver.FindElement(By.XPath("/html/body/div[2]/section/form/div[2]/input"));
            inpPw.Click();
            inpPw.SendKeys(TopSecret.eKsPw);
            config.driver.FindElement(By.XPath("/html/body/div[2]/section/form/button")).Click();
            Thread.Sleep(5000);
            string teksti = config.driver.FindElement(By.XPath("/html/body/div[2]/section/div[1]/h2")).Text;
            string txtExpected = "Kërkimi i gjobave individuale";
            Assert.AreEqual(txtExpected, teksti);


        }
        [Test]
        public void TS4_GjobatMeReference()
        {
            config.Hapja("https://ekosova.rks-gov.net/Service/9");
          
            config.driver.FindElement(By.XPath("/html/body/div[2]/section/div[2]/div[2]/a")).Click();
            IWebElement inpUser = config.driver.FindElement(By.XPath("/html/body/div[2]/section/form/div[1]/input"));
            inpUser.Click();
            inpUser.SendKeys(TopSecret.eKsUser);
            IWebElement inpPw = config.driver.FindElement(By.XPath("/html/body/div[2]/section/form/div[2]/input"));
            inpPw.Click();
            inpPw.SendKeys(TopSecret.eKsPw);
            config.driver.FindElement(By.XPath("/html/body/div[2]/section/form/button")).Click();
            Thread.Sleep(5000);
            IWebElement refInp = config.driver.FindElement(By.XPath("/html/body/div[2]/section/div[2]/div/table/tbody/tr/td[1]/input"));
            refInp.SendKeys(TopSecret.Leternjoftimi);
            config.driver.FindElement(By.XPath("/html/body/div[2]/section/div[2]/div/table/tbody/tr/td[2]/button")).Click();

            string teksti = config.driver.FindElement(By.XPath("/html/body/div[2]/section/div[3]/table/tbody/tr/th")).Text;
            string txtExpected = "nuk është identifikuar asnjë gjobë sipas kësaj reference.";
           
            if (teksti.ToLower().Contains(txtExpected))
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
