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

            //kontrollo asetin
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

            //kontrollo asetin
        }

        //sipas dates nuk e kom punu
    }
}
