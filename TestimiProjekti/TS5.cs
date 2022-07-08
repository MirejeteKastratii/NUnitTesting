using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Testimi;

namespace TestimiProjekti
{
    public  class TS5
    {
        Config config = new Config();
        [Test]
        public void TS5_BanderolaValide()
        {
            config.Hapja("https://ekosova.rks-gov.net/Service/36");
            config.driver.FindElement(By.XPath("/html/body/div[2]/section/div[2]/div/a")).Click();
            IWebElement userInput = config.driver.FindElement(By.XPath("/html/body/div[2]/section/form/div[1]/input"));
            userInput.Click();
            userInput.SendKeys(TopSecret.eKsUser);
            IWebElement userPw = config.driver.FindElement(By.XPath("/html/body/div[2]/section/form/div[2]/input"));
            userPw.Click();
            userPw.SendKeys(TopSecret.eKsPw);
            config.driver.FindElement(By.XPath("/html/body/div[2]/section/form/button")).Click();
            Thread.Sleep(3000);
            IWebElement bndInp = config.driver.FindElement(By.XPath("/html/body/div[2]/section/div[2]/div/table/tbody/tr[1]/td[1]/input"));
            bndInp.Click();
            bndInp.SendKeys(TopSecret.BanderolaAktive);
            config.driver.FindElement(By.XPath("/html/body/div[2]/section/div[2]/div/table/tbody/tr[1]/td[2]/button")).Click();
            Thread.Sleep(3000);
            string txtATCCode = config.driver.FindElement(By.XPath("/html/body/div[2]/section/div[3]/table/tbody/tr[1]/th")).Text;
            if (txtATCCode == "ATC kodi:")
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
