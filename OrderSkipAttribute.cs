// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnitCSharp.BaseClass;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace NUnitCSharp
   
{
    [TestFixture]
    public class OrderSkipAttribute
    {  
        [Test, Category("OrderSkipAttribute"),Order(1)]
        public void TestMethod1()
        {
            Assert.Ignore("Defect 12345");
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.facebook.com/";
            IWebElement emailTextField = driver.FindElement(By.XPath("//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            driver.Close();
        }
        [Test, Category("OrderSkipAttribute"),Order(0)]
        public void TestMethod2()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://www.facebook.com/";
            IWebElement emailTextField = driver.FindElement(By.XPath("//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            driver.Close();
        }
        [Test, Category("OrderSkipAttribute"),Order(2)]
        public void TestMethod3()
        {
            IWebDriver driver = new InternetExplorerDriver();
            driver.Url = "https://www.facebook.com/";
            IWebElement emailTextField = driver.FindElement(By.XPath("//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            driver.Close();
        }
    }
}
