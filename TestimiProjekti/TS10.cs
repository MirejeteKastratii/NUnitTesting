using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using Testimi;

namespace TestimiProjekti
{
    internal class TS10
    {
        [Test]
        public void TS10_TC1()
        {
            Config config = new Config();
            config.Hapja("https://www.facebook.com/events/create?acontext=%7B%22event_action_history%22%3A[%7B%22extra_data%22%3A%22%22%2C%22mechanism%22%3A%22left_rail%22%2C%22surface%22%3A%22bookmark%22%7D%2C%7B%22extra_data%22%3A%22%22%2C%22mechanism%22%3A%22left_rail%22%2C%22surface%22%3A%22bookmark%22%7D]%2C%22ref_notif_type%22%3Anull%7D&dialog_entry_point=bookmark&ref=110");
            IWebElement nrInp = config.driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div/div[3]/div[2]/form/div[2]/div[1]/input"));
            nrInp.Click();
            nrInp.SendKeys(TopSecret.FbNumber);
            IWebElement pwInp = config.driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div/div[3]/div[2]/form/div[2]/div[2]/div/div/input"));
            pwInp.SendKeys(TopSecret.FbPw);
            config.driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div/div[3]/div[2]/form/div[2]/div[3]/button")).Click();
            config.driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[3]/div/div/div/div[1]/div[1]/div[2]/div/div/div[2]/div[2]/div[1]/div[1]/div/div/div[1]/i")).Click();

        }
    }
}
