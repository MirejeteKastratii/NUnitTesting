using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Testimi;
//using System.Drawing;
//using System.Drawing.Design;
//using System.Drawing.Imaging;
 

namespace TestimiProjekti
{
    internal class TS9
    {
        Config config = new Config();
   
        [Test]
        public void TS9_TC1()
        {
            Config config = new Config();
            config.Hapja("https://kahoot.it/");
            IWebElement pinInp = config.driver.FindElement(By.XPath("/html/body/div/div[1]/div/div/div/div[3]/div[2]/main/div/form/input"));
            pinInp.Click();
            pinInp.SendKeys(TopSecret.KahootValidPin);
            Thread.Sleep(3000);
            IWebElement emriInp = config.driver.FindElement(By.XPath("/html/body/div/div[1]/div/div/div/div[3]/div[2]/main/div/form/input"));
            emriInp.Click();
            emriInp.SendKeys(TopSecret.KahootName);
            IWebElement butoni = config.driver.FindElement(By.XPath("/html/body/div/div[1]/div/div/div/div[3]/div[2]/main/div/form/button"));
            butoni.Click();
            string elMesazhi = config.driver.FindElement(By.XPath("/html/body/div/div[1]/div/div/div/main/h1/div/p[1]")).Text;
            string msgPritur = "You're in!";
            Assert.AreEqual(msgPritur, elMesazhi);
        }
        [Test]
        public void TS9_TC2()
        {
            Config config = new Config();
            config.Hapja("https://kahoot.it/");
            //Screenshot ss = ((ITakesScreenshot)config.driver).GetScreenshot();
            //ss.SaveAsFile("C:\\Users\\Mirejete Kastrati\\Desktop\\Test\\sample.png", OpenQA.Selenium.ScreenshotImageFormat.Png);
            IWebElement pinInp = config.driver.FindElement(By.XPath("/html/body/div/div[1]/div/div/div/div[3]/div[2]/main/div/form/input"));
            pinInp.Click();
            pinInp.SendKeys(TopSecret.KahootInvalidPin);
            config.driver.FindElement(By.XPath("/html/body/div/div[1]/div/div/div/div[3]/div[2]/main/div/form/button")).Click();
            Thread.Sleep(2000);
            string elMesazhi = config.driver.FindElement(By.XPath("/html/body/div/div[1]/div/div/div[2]/div/div[2]")).Text;
            string msgPritur = "We didn't recognize that game PIN. Please check and try again.";
            Assert.AreEqual(msgPritur, elMesazhi);
        }

    }
}
