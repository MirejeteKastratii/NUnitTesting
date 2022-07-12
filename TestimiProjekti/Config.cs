using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

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
        public void TakeScr(string parametri)
        {
         Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
         ss.SaveAsFile(("C:\\Users\\Mirejete Kastrati\\Desktop\\Test\\"+  parametri+".png"), OpenQA.Selenium.ScreenshotImageFormat.Png);
        }
        public bool CheckFile(string name,string extension)
        {
            string currentFile = @"C:\Users\Mirejete Kastrati\Downloads\" + name + "." + extension;
            if (File.Exists(currentFile))// helps to check if the zip file is present
            {
                return true;// if the zip file exists return boolean true
            }

            return false;// if the zip file does not exist return boolean false
        }
    }
}
