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
    internal class TS10
    {
        //unknown error: unexpcted comand response

        [Test]
        public void TS10_TC1()
        {
            Config config = new Config();
            Actions action = new Actions(config.driver);
            config.Hapja("https://mars.nasa.gov/participate/send-your-name/mars2020/");
            config.driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/div/div/div/div[1]/div/div[1]/div/div[1]/div/a")).Click();
            Thread.Sleep(3000);
            IWebElement emriInp = config.driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/div/div/div[1]/form/div/div[1]/div[1]/div[2]/input"));
            emriInp.Click();
            emriInp.SendKeys("Mirejete");
            IWebElement lastName = config.driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/div/div/div[1]/form/div/div[1]/div[2]/div[2]/input"));
            lastName.Click();
            lastName.SendKeys("Kastrati");
            //config.driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/div/div/div[1]/form/div/div[1]/div[3]/div[2]")).Click();
            //config.driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/div/div/div[1]/form/div/div[1]/div[3]/div[2]")).Click();
            IWebElement location = config.driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/div/div/div[1]/form/div/div[1]/div[3]/div[2]/select"));
            location.Click();
            location.SendKeys("Albania");
            location.Click();
            IWebElement postalCode = config.driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/div/div/div[1]/form/div/div[1]/div[4]/div[2]/input"));
            postalCode.Click();
            postalCode.SendKeys("20000");
            IWebElement email = config.driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/div/div/div[1]/form/div/div[1]/div[5]/div[2]/input"));
            email.Click();
            email.SendKeys("mirejetak@gmail.com");
            config.driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/div/div/div[1]/form/div/div[2]/button")).Click();
            Thread.Sleep(3000);
            // IWebElement downloadBtn=  config.driver.FindElement(By.Id("downloadTicket"));
            IWebElement el = config.driver.FindElement(By.CssSelector("#Boarding-Pass-Page > div > div.introText.grid > div.text-decription.rowItem.large.textAlignCenter > div"));
            //  action.MoveToElement(downloadBtn).Click().Perform();
            bool exists = config.CheckFile("BoardingPass_MyNameOnFutureMission", "png");
            config.driver.Quit();

        }
        [Test]
        public void TS10_TC2()
        {
            Config config = new Config();
            Actions action = new Actions(config.driver);
            config.Hapja("https://mars.nasa.gov/participate/send-your-name/mars2020/");
            config.driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/div/div/div/div[1]/div/div[2]/div/div[1]/div/a")).Click();
            Thread.Sleep(3000);
            IWebElement emri = config.driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/div/form/div/div[1]/div[2]/div[1]/div[1]/div[2]/input"));
            emri.Click();
            emri.SendKeys("Mirejete");
            IWebElement mbiemri = config.driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/div/form/div/div[1]/div[2]/div[1]/div[2]/div[2]/input"));
            mbiemri.Click();
            mbiemri.SendKeys("Kastrati");
            IWebElement location = config.driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/div/form/div/div[1]/div[2]/div[1]/div[3]/div[2]/select"));
            location.Click();
            location.SendKeys("Albania");
            location.Click();
            IWebElement postalCode = config.driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/div/form/div/div[1]/div[2]/div[1]/div[4]/div[2]/input"));
            postalCode.Click();
            postalCode.SendKeys("20000");
            config.driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/div/form/div/div[2]/button")).Click();
            IWebElement el = config.driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/div/div[1]/div[1]/div"));
            //  IWebElement el = config.driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/div/div[2]/div[2]/div[1]/a"));
            string msgExpected = "Your name will fly on NASA's next Mars mission!";
            Assert.AreEqual(msgExpected, el.Text);
   

        }
    }
}
