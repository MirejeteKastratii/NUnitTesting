using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TestimiProjekti
{
    internal class TS2
    {
        [Test]
        public void TS2_TC1_Shumegjuhesia_Ang()
        {
            Config config = new Config();
            config.Hapja("https://mfa-ks.net/en/misionet/493/ambasadat-e-republiks-s-kosovs/493");
            IWebElement butoni = config.driver.FindElement(By.XPath("/html/body/div[3]/div[1]/div/div[1]/div/div[2]/button"));
            butoni.Click();
            config.driver.FindElement(By.XPath("/html/body/div[3]/div[1]/div/div[1]/div/div[2]/div/a[2]")).Click();
            Thread.Sleep(2000);
            string txt = config.driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[1]/div[1]/div/form/h2")).Text;
           
            string txtEcpected = "EMBASSIES OF THE REPUBLIC OF KOSOVO";
            config.TakeScr("GjuhaAngleze");
            Assert.AreEqual(txtEcpected, txt);


        }
        [Test]
        public void TS2_TC2_Shumegjuhesia_Shqip()
        {
            Config config = new Config();
            config.Hapja("https://mfa-ks.net/en/misionet/493/ambasadat-e-republiks-s-kosovs/493");
            IWebElement butoni = config.driver.FindElement(By.XPath("/html/body/div[3]/div[1]/div/div[1]/div/div[2]/button"));
            butoni.Click();
            config.driver.FindElement(By.XPath("/html/body/div[3]/div[1]/div/div[1]/div/div[2]/div/a[1]")).Click();
            Thread.Sleep(2000);
            string txt = config.driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[1]/div[1]/div/form/h2")).Text;
           
            string txtEcpected = "AMBASADAT E REPUBLIKËS SË KOSOVËS";
            Assert.AreEqual(txtEcpected, txt);


        }
    }
}
