using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TestimiProjekti
{
    internal class TS6
    {
        Config config = new Config();
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void FiltrimiProdukteveAlfabetikisht()
        {
            config.Hapja("https://aztechonline.com/");
            Thread.Sleep(10000);
            IWebElement kategoria = config.driver.FindElement(By.XPath("/html/body/div[1]/div/div/header[2]/div[2]/div/nav/ul/li[1]/a/span"));
            kategoria.Click();
            IWebElement selectFilter = config.driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[1]/div/div/div/div/div/section/div[2]/div[2]/div[1]/div/div[1]/select"));
            selectFilter.Click();
            IWebElement perzgjedhjaAlfabetikisht = config.driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[1]/div/div/div/div/div/section/div[2]/div[2]/div[1]/div/div[1]/select/option[1]"));
            perzgjedhjaAlfabetikisht.Click();

            string elPare = config.driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[1]/div/div/div/div/div/section/div[2]/div[2]/div[2]/div[1]/div[1]/div/div/div[1]/a/span")).Text;
            if (elPare.ToLower().StartsWith('a'))
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }
        [Test]
        public void FiltrimiProdukteveNeBazeTeCmimeveTeLira()
        {
            config.Hapja("https://aztechonline.com/");
            Thread.Sleep(10000);
            IWebElement kategoria = config.driver.FindElement(By.XPath("/html/body/div[1]/div/div/header[2]/div[2]/div/nav/ul/li[1]/a/span"));
            kategoria.Click();
            IWebElement selectFilter = config.driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[1]/div/div/div/div/div/section/div[2]/div[2]/div[1]/div/div[1]/select"));
            selectFilter.Click();
            IWebElement perzgjedhMeTeLirat = config.driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[1]/div/div/div/div/div/section/div[2]/div[2]/div[1]/div/div[1]/select/option[5]"));
            perzgjedhMeTeLirat.Click();
            string cmimiMeIUlet = config.driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[1]/div/div/div/div/div/section/div[2]/div[2]/div[2]/div[1]/div[1]/div/div/div[2]/div/span")).Text;
            string secondCmimi = config.driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[1]/div/div/div/div/div/section/div[2]/div[2]/div[2]/div[1]/div[2]/div/div/div[2]/div/span")).Text;
            cmimiMeIUlet = cmimiMeIUlet.Remove(0, 1);
            secondCmimi = secondCmimi.Remove(0, 1);
            double c1Int = Double.Parse(cmimiMeIUlet);
            double c2Int = Double.Parse(secondCmimi);
            if (c1Int < c2Int)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }


            //kontrollo asetin
        }
        [Test]
        public void FiltrimiProdukteveNeBazeTeCmimeveTeShtrenjta()
        {
            config.Hapja("https://aztechonline.com/");
            Thread.Sleep(10000);
            IWebElement kategoria = config.driver.FindElement(By.XPath("/html/body/div[1]/div/div/header[2]/div[2]/div/nav/ul/li[1]/a/span"));
            kategoria.Click();
            IWebElement selectFilter = config.driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[1]/div/div/div/div/div/section/div[2]/div[2]/div[1]/div/div[1]/select"));
            selectFilter.Click();
            IWebElement perzgjedhMeTeShtrenjtat = config.driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[1]/div/div/div/div/div/section/div[2]/div[2]/div[1]/div/div[1]/select/option[6]"));
            perzgjedhMeTeShtrenjtat.Click();

            string cmimiMeILarte = config.driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[1]/div/div/div/div/div/section/div[2]/div[2]/div[2]/div[1]/div[2]/div/div/div[2]/div/span[2]")).Text;
            string secondCmimiMeILarte = config.driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[1]/div/div/div/div/div/section/div[2]/div[2]/div[2]/div[1]/div[3]/div/div/div[2]/div/span[2]")).Text;
            cmimiMeILarte = cmimiMeILarte.Remove(0, 1);
            secondCmimiMeILarte = secondCmimiMeILarte.Remove(0, 1);
            double first = Double.Parse(cmimiMeILarte);
            double second = Double.Parse(secondCmimiMeILarte);
            if (first > second)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }

        }

        //sipas dates nuk e kom punu
    }
}
