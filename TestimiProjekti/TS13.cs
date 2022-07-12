using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using Testimi;

namespace TestimiProjekti
{
    internal class TS13
    {
       

    
        Config config = new Config();
        [Test]
        public void TS13_TC1()
        {

            config.Hapja("https://ekosova.rks-gov.net/");
            config.driver.FindElement(By.XPath("/html/body/div[2]/section/div[2]/button[2]")).Click();
            Thread.Sleep(3000);
            IWebElement nrPersonalInp = config.driver.FindElement(By.XPath("/html/body/div[2]/section/form/div[1]/input"));
            nrPersonalInp.Click();
            nrPersonalInp.SendKeys(TopSecret.eKsUser);
            IWebElement pwInp = config.driver.FindElement(By.XPath("/html/body/div[2]/section/form/div[2]/input"));
            pwInp.Click();
            pwInp.SendKeys(TopSecret.eKsPw);
            config.driver.FindElement(By.XPath("/html/body/div[2]/section/form/button")).Click();
            Thread.Sleep(3000);
            config.driver.FindElement(By.XPath("/html/body/header/div[2]/nav/ul/li[2]/a")).Click();
            Thread.Sleep(3000);
            config.driver.FindElement(By.XPath("/html/body/div[2]/section/div[2]/a[4]")).Click();

            Thread.Sleep(3000);
            config.driver.FindElement(By.XPath("/html/body/div[2]/section/div[2]/div[1]/a")).Click();
            Thread.Sleep(3000);
            string elTxt = config.driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/p")).Text;
            string txtExpected = "Për momentin, Ministria e Shëndetësisë nuk ka termine të lira nëpër qendrat e vaksinimit në vendbanimin tuaj. Ju lutem provoni më vonë.";
            Assert.AreEqual(txtExpected, elTxt);

        }
        [Test]
        public void TerheqjaPasaportesElektronikeTeVaksinimit()
        {
            Actions action = new Actions(config.driver);
            config.Hapja("https://ekosova.rks-gov.net/Security");

            IWebElement userINp = config.driver.FindElement(By.XPath("/html/body/div[2]/section/form/div[1]/input"));
            userINp.Click();
            userINp.SendKeys(TopSecret.EKsFlora);
            IWebElement pwInp = config.driver.FindElement(By.XPath("/html/body/div[2]/section/form/div[2]/input"));
            userINp.Click();
            pwInp.SendKeys(TopSecret.EKsFloraPw);
            config.driver.FindElement(By.XPath("/html/body/div[2]/section/form/button")).Click();
            Thread.Sleep(3000);
            config.driver.FindElement(By.XPath("/html/body/header/div[2]/nav/ul/li[2]/a")).Click();
            Thread.Sleep(3000);
            IWebElement shendetesia = config.driver.FindElement(By.XPath("/html/body/div[2]/section/div[2]/a[4]"));
            action.MoveToElement(shendetesia).Click().Perform();
            Thread.Sleep(5000);
            IWebElement pasaporta = config.driver.FindElement(By.XPath("/html/body/div[2]/section/div[2]/div[3]/a"));
//          pasaporta.Click();
            action.MoveToElement(pasaporta).Click().Perform();

            config.driver.FindElement(By.XPath("/html/body/div[2]/section/div[3]/div/table/tbody/tr/td/button")).Click();
            bool exists = config.CheckFile("Certificate","pdf");
            if (exists)
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