using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TestimiProjekti
{
    internal class TS14
    {
        Config config=new Config();
        [SetUp]
        public void Setup()
        {

        }
        //nuk funksionon duhet me ndreq edhe nuk eshte e perfundume
        [Test]
        public void SortimiProdukteveNeBazeTeLokacionit()
        {
            config.Hapja("https://www.merrjep.com/shpalljet/");
            Thread.Sleep(3000);
            IWebElement kategoria = config.driver.FindElement(By.XPath("//*[@id=\"CategoryId\"]"));
            kategoria.Click();
          IWebElement perzgjedhjaKategorise = config.driver.FindElement(By.XPath("/html/body/div[2]/section/div[4]/div[1]/form/fieldset/div[1]/ul/li[2]/select/option[3]"));
            perzgjedhjaKategorise.Click();
            Thread.Sleep(3000);
            IWebElement lokacioni = config.driver.FindElement(By.XPath("/html/body/div[2]/section/div[4]/div[1]/form/fieldset/div[1]/ul/li[3]/select"));
            lokacioni.Click();
            IWebElement perzgjedhLokacionin = config.driver.FindElement(By.XPath("/html/body/div[2]/section/div[4]/div[1]/form/fieldset/div[1]/ul/li[3]/select/option[3]"));

            perzgjedhLokacionin.Click();
            Thread.Sleep(3000);
            string txtLocation = config.driver.FindElement(By.XPath("/html/body/div[2]/section/div[4]/div[1]/div[4]/div[2]/div[8]/div[1]/div/div[1]/div[2]/a[2]")).Text;
            if (txtLocation.ToLower() == "besianë")
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
