using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Testimi;

namespace TestimiProjekti
{
    internal class TS3
    {
        Config config = new Config();
        [Test]
        public void AplikimiMeProfilTeVerifikuarJashteAfatitTeAplikimeve()
        {
            config.Hapja("https://ekosova.rks-gov.net/Services");
            IWebElement refuzo = config.driver.FindElement(By.XPath("/html/body/div[3]/div/button[2]"));
            refuzo.Click();

            IWebElement arsimi = config.driver.FindElement(By.XPath("/html/body/div[2]/section/div[2]/a[8]"));
            arsimi.Click();
            Thread.Sleep(3000);

            IWebElement bursa = config.driver.FindElement(By.XPath("/html/body/div[2]/section/div[2]/div[30]/a"));
            bursa.Click();
            Thread.Sleep(3000);

            IWebElement inputNr = config.driver.FindElement(By.XPath("/html/body/div[2]/section/form/div[1]/input"));
            inputNr.Click();
            inputNr.SendKeys(TopSecret.Leternjoftimi);

            IWebElement inputPw = config.driver.FindElement(By.XPath("/html/body/div[2]/section/form/div[2]/input"));
            inputPw.Click();
            inputPw.SendKeys(TopSecret.EKsFloraPw);

            IWebElement hyr = config.driver.FindElement(By.XPath("/html/body/div[2]/section/form/button"));
            hyr.Click();
            Thread.Sleep(2000);

            string txt = config.driver.FindElement(By.XPath("/html/body/div[3]/div/div[2]/p")).Text;
            if (txt.Contains("Ka skaduar afati për të aplikuar për bursë elitare"))
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }

        }
        [Test]
        public void AplikimiPerBursaMeProfilTePaautorizuar()
        {
            Actions actions = new Actions(config.driver);
            config.Hapja("https://ekosova.rks-gov.net/Services");
            IWebElement refuzo = config.driver.FindElement(By.XPath("/html/body/div[3]/div/button[2]"));
            actions.MoveToElement(refuzo).Click().Perform();

            IWebElement arsimi = config.driver.FindElement(By.XPath("/html/body/div[2]/section/div[2]/a[8]"));
            arsimi.Click();
            Thread.Sleep(2000);

            IWebElement bursa = config.driver.FindElement(By.XPath("/html/body/div[2]/section/div[2]/div[30]/a"));
            bursa.Click();
            Thread.Sleep(2000);

            IWebElement inputNr = config.driver.FindElement(By.XPath("/html/body/div[2]/section/form/div[1]/input"));
            inputNr.Click();
            inputNr.SendKeys(TopSecret.LeternjoftimiPerProfilTePaautorizuar);


            IWebElement inputPw = config.driver.FindElement(By.XPath("/html/body/div[2]/section/form/div[2]/input"));
            inputPw.Click();
            inputPw.SendKeys(TopSecret.pwPerProfilTePaautorizuar);

            IWebElement hyr = config.driver.FindElement(By.XPath("/html/body/div[2]/section/form/button"));
            hyr.Click();
            Thread.Sleep(3000);

            string txt = config.driver.FindElement(By.XPath("/html/body/div[3]/div/div[2]/p")).Text;
            if (txt.Contains("Parakusht për shfrytëzimin e këtij shërbimi është konfirmimi i email adresës përmes vegzës që ju është dërguar me rastin e hapjes së llogarisë."))
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
