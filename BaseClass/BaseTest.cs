using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitCSharp.BaseClass
{
    public class BaseTest
    {
        public IWebDriver driver;
       [OneTimeSetUp]
        public void Open() 
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.facebook.com/";
        }
        [OneTimeTearDown]
        public void Close()
        {
            driver.Quit();
        }
    }
}
