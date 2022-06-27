using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestimiProjekti
{
    public  class Config
    {
       public IWebDriver driver = new ChromeDriver();
        public  void Hapja(string url)
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
        }
    }
}
