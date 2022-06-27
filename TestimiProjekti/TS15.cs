using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using Testimi;


namespace TestimiProjekti
{
    public class Tests
    {
        Config config = new Config();
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TS15_Meet_Valid()
        {
            config.Hapja("https://meet.google.com/");

            IWebElement newMeeting = config.driver.FindElement(By.XPath("//*[@id=\"page-content\"]/section[1]/div/div[1]/div[2]/div/a/button"));
            newMeeting.Click();
            IWebElement emailInput = config.driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div/div[2]/div/div/div[2]/div/div[1]/div/form/span/section/div/div/div[1]/div/div[1]/div/div[1]/input"));
            emailInput.Click();
            emailInput.SendKeys(TopSecret.Email);
            config.driver.FindElement(By.XPath("//*[@id=\"identifierNext\"]/div/button")).Click();
            Thread.Sleep(2000);
            IWebElement passwordInput = config.driver.FindElement(By.XPath("//*[@id=\"password\"]/div[1]/div/div[1]/input"));
            passwordInput.Click();
            passwordInput.SendKeys(TopSecret.Password);
            config.driver.FindElement(By.XPath("//*[@id=\"passwordNext\"]/div/button")).Click();
            Thread.Sleep(5000);
            string text = config.driver.FindElement(By.XPath("//*[@id=\"yDmH0d\"]/div[3]/div[2]/div/div[2]/button/span")).Text;
            //driver.Close();
            if (text.ToLower() == "dismiss")
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
            config.driver.Quit();
        }
        [Test]
        public void TS15_Meet_InValid()
        {
            config.Hapja("https://meet.google.com/");
            IWebElement newMeeting = config.driver.FindElement(By.XPath("//*[@id=\"page-content\"]/section[1]/div/div[1]/div[2]/div/a/button"));
            newMeeting.Click();
            IWebElement emailInput = config.driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div/div[2]/div/div/div[2]/div/div[1]/div/form/span/section/div/div/div[1]/div/div[1]/div/div[1]/input"));
            emailInput.Click();
            emailInput.SendKeys(TopSecret.Email);
            config.driver.FindElement(By.XPath("//*[@id=\"identifierNext\"]/div/button")).Click();
            Thread.Sleep(2000);
            IWebElement passwordInput = config.driver.FindElement(By.XPath("//*[@id=\"password\"]/div[1]/div/div[1]/input"));
            passwordInput.Click();
            passwordInput.SendKeys(TopSecret.WrongPw);
            config.driver.FindElement(By.XPath("//*[@id=\"passwordNext\"]/div/button")).Click();
            Thread.Sleep(5000);
                 string text = config.driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div/div[2]/div/div/div[2]/div/div[1]/div/form/span/section/div/div/div[1]/div[2]/div[2]/span")).Text;
            
            if (text.Contains("Wrong password. Try again or click Forgot password to reset it."))
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
            config.driver.Close();
        }
    }
}