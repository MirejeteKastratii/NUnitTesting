using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Testimi;

namespace TestimiProjekti
{
    public class TS12
    {

        Config config = new Config();

        [Test]
        public void TS12_TC1()
        {
            config.Hapja("https://ekosova.rks-gov.net/Public/296");
            IWebElement emriInp = config.driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/form/div[1]/table/tbody/tr[1]/td/input"));
            emriInp.Click();
            emriInp.SendKeys(TopSecret.emri);
            Actions actions = new Actions(config.driver);
            IWebElement mbiemriInp = config.driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/form/div[1]/table/tbody/tr[2]/td/input"));
            mbiemriInp.SendKeys(TopSecret.mbiemri);
            IWebElement emailInp = config.driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/form/div[1]/table/tbody/tr[3]/td/input"));
            emailInp.Click();
            emailInp.SendKeys(TopSecret.Email);
            IWebElement dateInp = config.driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/form/div[1]/table/tbody/tr[4]/td/input"));

            IWebElement pasaportaInp = config.driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/form/div[1]/table/tbody/tr[6]/td/input"));
            actions.MoveToElement(pasaportaInp).Click().Perform();
            pasaportaInp.SendKeys(TopSecret.Pasaporta);
            IWebElement arsyejaInp = config.driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/form/div[1]/table/tbody/tr[8]/td/textarea"));

            actions.MoveToElement(arsyejaInp).Click().Perform();

            arsyejaInp.SendKeys("Pa arsye");
            IWebElement dataLire = config.driver.FindElement(By.XPath("/html/body/div[ 2]/div/div[2]/form/div[2]/div[1]/div[2]"));
            dataLire.Click();
            Thread.Sleep(1500);
            IWebElement oraLire = config.driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/form/div[2]/div[2]/div[1]/div[2]"));
            oraLire.Click();
            IWebElement rezervo = config.driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div/button[2]"));

            rezervo.SendKeys(Keys.Tab);
            rezervo.SendKeys(Keys.Enter);
            dateInp.SendKeys("12Jan");
            dateInp.SendKeys(Keys.Tab);
            dateInp.SendKeys("2000");
            rezervo.Click();
            string elMesazhi = config.driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/form/div[1]/table/tbody/tr[7]/td/label[2]")).Text;
            string msg = "Fusha duhet plotësuar";
            Assert.AreEqual(msg, elMesazhi);


        }

        [Test]
        public void TS12_TC2()
        {
            config.Hapja("https://ekosova.rks-gov.net/Public/296");
            IWebElement emriInp = config.driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/form/div[1]/table/tbody/tr[1]/td/input"));
            emriInp.Click();
            emriInp.SendKeys(TopSecret.emri);
            Actions actions = new Actions(config.driver);
            IWebElement mbiemriInp = config.driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/form/div[1]/table/tbody/tr[2]/td/input"));
            mbiemriInp.SendKeys(TopSecret.mbiemri);
            IWebElement emailInp = config.driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/form/div[1]/table/tbody/tr[3]/td/input"));
            actions.MoveToElement(emailInp).Click();
            emailInp.SendKeys(TopSecret.emailForW3);
            IWebElement dateInp = config.driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/form/div[1]/table/tbody/tr[4]/td/input"));

            IWebElement pasaportaInp = config.driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/form/div[1]/table/tbody/tr[6]/td/input"));
            actions.MoveToElement(pasaportaInp).Click().Perform();
            pasaportaInp.SendKeys("asdfdsfafdasf");
            IWebElement lejeQendrimiInp = config.driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/form/div[1]/table/tbody/tr[7]/td/input"));
            actions.MoveToElement(lejeQendrimiInp).Click().Perform();
            lejeQendrimiInp.SendKeys("adfdfasfasdfasdfsadf");
            IWebElement arsyejaInp = config.driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/form/div[1]/table/tbody/tr[8]/td/textarea"));

            actions.MoveToElement(arsyejaInp).Click().Perform();

            arsyejaInp.SendKeys("Pa arsye");
            IWebElement dataLire = config.driver.FindElement(By.XPath("/html/body/div[ 2]/div/div[2]/form/div[2]/div[1]/div[2]"));
            dataLire.Click();
            Thread.Sleep(1500);
            IWebElement oraLire = config.driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/form/div[2]/div[2]/div[1]/div[2]"));
            oraLire.Click();
            IWebElement rezervo = config.driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div/button[2]"));

            rezervo.SendKeys(Keys.Tab);
            rezervo.SendKeys(Keys.Enter);
            dateInp.SendKeys("12Jan");
            dateInp.SendKeys(Keys.Tab);
            dateInp.SendKeys("2000");
            rezervo.Click();
            Thread.Sleep(5000);
            string elMesazhi = config.driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/p")).Text;
            string mesazhi = "Lejeqendirmi nuk eshte valid";
            if (elMesazhi == mesazhi)
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
