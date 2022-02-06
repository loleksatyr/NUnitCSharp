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

namespace NUnitCSharp
   
{
    [TestFixture]
    public class TestClass : BaseTest
    {
        [Test, Category("Smoke Testing")]
        public void TestMethod1()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath("//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/div/div/div/div[3]/button[2]")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div/div/div/div[2]/div/div[1]/form/div[5]/a")).SendKeys(Keys.Enter);
            Thread.Sleep(1000);
            IWebElement monthDropdownList = driver.FindElement(By.Name("birthday_month")); 
            SelectElement element = new SelectElement(monthDropdownList);
            element.SelectByIndex(1);
            element.SelectByText("maj");
            element.SelectByValue("6");
            Thread.Sleep(1000);

        }
        [Test, Category("Regression Testing")]
        public void TestMethod2()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath("//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
        }
        [Test, Category("Smoke Testing")]
        public void TestMethod3()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath("//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            Thread.Sleep(5000);
        }
    }
}
