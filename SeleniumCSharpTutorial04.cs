using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NUnitCSharp
{
    [TestFixture]
    public class SeleniumCSharpTutorial04
    {
        IWebDriver driver = null;
        [Test]
        [Author("Bartek","mail")]
        [Description("Facebook login verify")]
        [TestCaseSource("DataDriverTesting")]
        public void Test1(String urlName) 
        {
            try
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                //driver.Url = "https://www.facebook.com/";
                driver.Url = urlName;
                IWebElement emailTextField = driver.FindElement(By.XPath("//*[@id='email']"));
                //IWebElement emailTextField = driver.FindElement(By.XPath("//*[@id='abcd']"));
                emailTextField.SendKeys("Selenium C#");
                driver.Quit();
            }
            catch (Exception e)
            {
                ITakesScreenshot ts = driver as ITakesScreenshot;
                Screenshot screenshot = ts.GetScreenshot();
                screenshot.SaveAsFile("C:\\Users\\czarn\\source\\repos\\NUnitCSharp\\Screenshots\\screen.jpeg",ScreenshotImageFormat.Jpeg);
                Console.WriteLine(e.StackTrace);
                throw;
            }
            finally
            {
                if (driver != null) 
                {
                    driver.Quit();
                }

            }
            
        }
        /* [Test]
         [Author("Bartek", "mail")]
         [Description("Facebook login verify")]
         public void Test2()
         {
             IWebDriver driver = new ChromeDriver();
             driver.Manage().Window.Maximize();
             driver.Url = "https://www.facebook.com/";
             IWebElement emailTextField = driver.FindElement(By.XPath("//*[@id='email']"));
             emailTextField.SendKeys("Selenium C#");
             driver.Quit();
         }
        */
        static IList DataDriverTesting() {
            ArrayList list = new ArrayList();
            list.Add("https://www.facebook.com/");
            //list.Add("https://www.youtube.com/");
            //list.Add("https://gmail.com/");    
            return list;
        }

    }
}
