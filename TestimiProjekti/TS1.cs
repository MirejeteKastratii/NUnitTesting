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
    internal class TS1
    {
        Config config = new Config();
        public void Setup()
        {

        }
        [Test]
        public void AplikimiPerLejeqendrimPerHereTePare()
        {
            config.Hapja("https://ekosova.rks-gov.net/Public/295");
            Thread.Sleep(2000);
            config.driver.FindElement(By.XPath("/html/body/div[3]/div/button[1]")).Click();
            IWebElement emri = config.driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/form/div[1]/table/tbody/tr[1]/td/input"));
            emri.Click();
            emri.SendKeys(TopSecret.emri);
            IWebElement mbiemri = config.driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/form/div[1]/table/tbody/tr[2]/td/input"));
            mbiemri.Click();
            mbiemri.SendKeys(TopSecret.mbiemri);
            IWebElement email = config.driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/form/div[1]/table/tbody/tr[3]/td/input"));
            email.Click();
            email.SendKeys(TopSecret.emailForW3);
            IWebElement datelindja = config.driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/form/div[1]/table/tbody/tr[4]/td/input"));
            Actions actions = new Actions(config.driver);
            actions.MoveToElement(datelindja).Click().Perform();
            //  datelindja.SendKeys(TopSecret.data.ToString("dd:MMMM:yyyy")) ;
            datelindja.SendKeys("20121985");
            IWebElement pasaporta = config.driver.FindElement(By.XPath("//*[@id=\"PassportNumber\"]"));
            actions.MoveToElement(pasaporta).Click().Perform();
            
            pasaporta.SendKeys(TopSecret.Pasaporta);
            IWebElement arsyeja = config.driver.FindElement(By.XPath("//*[@id=\"Reason\"]"));
            
            actions.MoveToElement(arsyeja).Click().Perform();
          
            arsyeja.SendKeys("qwert");
            IWebElement dataLire = config.driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/form/div[2]/div[1]/div[3]"));
            dataLire.Click();
            Thread.Sleep(1500);
            IWebElement oraLire = config.driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/form/div[2]/div[2]/div[2]/div[2]"));
            oraLire.Click();
            IWebElement rezervo = config.driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div/button[2]"));
          //  rezervo.Click();
            actions.MoveToElement(rezervo).Click().Perform();
            datelindja.SendKeys("12Dec");
            datelindja.SendKeys(Keys.Tab);
            datelindja.SendKeys("2001");
            rezervo.Click();

            Thread.Sleep(5000);
            string str = config.driver.FindElement(By.XPath("/html/body/div[3]/div/div[1]/h3")).Text;
            if (str.ToLower() == "njoftim")
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }
        [Test]
        public void AplikimiPerLejeQendrimPaDate()
        {
            config.Hapja("https://ekosova.rks-gov.net/Public/295");
            Thread.Sleep(2000);
            config.driver.FindElement(By.XPath("/html/body/div[3]/div/button[1]")).Click();
            IWebElement emri = config.driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/form/div[1]/table/tbody/tr[1]/td/input"));
            emri.Click();
            emri.SendKeys(TopSecret.emri);
            IWebElement mbiemri = config.driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/form/div[1]/table/tbody/tr[2]/td/input"));
            mbiemri.Click();
            mbiemri.SendKeys(TopSecret.mbiemri);
            IWebElement email = config.driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/form/div[1]/table/tbody/tr[3]/td/input"));
            email.Click();
            email.SendKeys(TopSecret.emailForW3);
            IWebElement datelindja = config.driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/form/div[1]/table/tbody/tr[4]/td/input"));
            Actions actions = new Actions(config.driver);
            actions.MoveToElement(datelindja).Click().Perform();
            //  datelindja.SendKeys(TopSecret.data.ToString("dd:MMMM:yyyy")) ;
            datelindja.SendKeys("20121985");
            IWebElement pasaporta = config.driver.FindElement(By.XPath("//*[@id=\"PassportNumber\"]"));
            actions.MoveToElement(pasaporta).Click().Perform();

            pasaporta.SendKeys(TopSecret.Pasaporta);
            IWebElement arsyeja = config.driver.FindElement(By.XPath("//*[@id=\"Reason\"]"));

            actions.MoveToElement(arsyeja).Click().Perform();

            arsyeja.SendKeys("qwert");
            IWebElement dataLire = config.driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/form/div[2]/div[1]/div[3]"));
            dataLire.Click();
            Thread.Sleep(1500);
            //IWebElement oraLire = config.driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/form/div[2]/div[2]/div[2]/div[2]"));
            //oraLire.Click();
            IWebElement rezervo = config.driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div/button[2]"));
            //  rezervo.Click();
            actions.MoveToElement(rezervo).Click().Perform();
            datelindja.SendKeys("12Dec");
            datelindja.SendKeys(Keys.Tab);
            datelindja.SendKeys("2001");
            rezervo.Click();

            Thread.Sleep(5000);
            string str = config.driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/p")).Text;
            if (str.ToLower() == "ju lutem përcaktoni datën dhe kohën e terminit.")
            {
                Assert.Pass();
                config.driver.Close();
            }
            else
            {
                Assert.Fail();
                config.driver.Close();
            }
        }
    }
}
