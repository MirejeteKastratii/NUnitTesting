using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Testimi;

namespace TestimiProjekti
{
    internal class TS8
    {
        Config config = new Config();

        [Test]
        public void KrijimiSpacesMeTemplate()
        {
            config.Hapja("https://spaces.w3schools.com/createspace/stepone");
            IWebElement inputEmail = config.driver.FindElement(By.XPath("//*[@id=\"modalusername\"]"));
            inputEmail.Click();
            inputEmail.SendKeys(TopSecret.emailForW3);
            IWebElement inputPassword = config.driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[4]/div[1]/div/div[2]/form/div[2]/div[2]/input"));
            inputPassword.Click();
            inputPassword.SendKeys(TopSecret.passwordW3);
            IWebElement login = config.driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div/div[4]/div[1]/div/div[4]/div[1]/button"));
            login.Click();
            Thread.Sleep(10000);
            IWebElement continueBtn = config.driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[3]/div/a/button"));
            continueBtn.Click();
            Thread.Sleep(2000);
            IWebElement continueBtn2 = config.driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[1]/div[2]/a/button"));
            continueBtn2.Click();
            Thread.Sleep(2000);
            IWebElement inputNameWorkspace = config.driver.FindElement(By.XPath("//*[@id=\"root\"]/div[3]/div[2]/div[2]/form/div/input"));
            inputNameWorkspace.Click();
            inputNameWorkspace.SendKeys("abcdefughyhriinvest");
            Thread.Sleep(2000);
            IWebElement ctn3 = config.driver.FindElement(By.XPath("//*[@id=\"root\"]/div[3]/div[1]/div[2]/a/button"));
            ctn3.Click();
            Thread.Sleep(5000);
            string spaceTxt = config.driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[2]/div/div/table/tbody/tr[1]/td[1]/div/div/div[1]")).Text;
            if (spaceTxt == "abcdefughyhriinvest")
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
          
        }
        [Test]
        public void KrijimiSpacePaTemplate()
        {
            config.Hapja("https://my-learning.w3schools.com/");
            IWebElement inputEmail = config.driver.FindElement(By.XPath("//*[@id=\"modalusername\"]"));
            inputEmail.Click();
            inputEmail.SendKeys(TopSecret.emailForW3);
            IWebElement inputPassword = config.driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[4]/div[1]/div/div[2]/form/div[2]/div[2]/input"));
            inputPassword.Click();
            inputPassword.SendKeys(TopSecret.passwordW3);
            IWebElement login = config.driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[4]/div[1]/div/div[4]/div[1]/button"));
            login.Click();
            Thread.Sleep(10000);
            IWebElement spacesNav = config.driver.FindElement(By.XPath("//*[@id=\"navigation\"]/a[5]"));
            spacesNav.Click();
            Thread.Sleep(5000);
            IWebElement createSpace = config.driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[1]/div[2]/span[3]/button"));
            createSpace.Click();
            Thread.Sleep(5000);
            IWebElement createBlank = config.driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[2]/div[3]/div"));
            createBlank.Click();
            IWebElement continueBtn = config.driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[3]/div/a/button"));
            continueBtn.Click();
            Thread.Sleep(4000);
            IWebElement nameSpace = config.driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[2]/div[2]/form/div/input"));
            nameSpace.Click();
            nameSpace.SendKeys("space1200fm1riinvest");
            IWebElement continueBtn2 = config.driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[1]/div[2]/a/button"));
            continueBtn2.Click();
            Thread.Sleep(5000);
            string txtSpace = config.driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[2]/div/div/table/tbody/tr[1]/td[1]/div/div/div[1]")).Text;
            if (txtSpace == "space1200fm1riinvest")
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
