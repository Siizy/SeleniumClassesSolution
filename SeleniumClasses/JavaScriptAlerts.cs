using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace SeleniumClasses
{
    internal class JavaScriptAlerts
    { 
    IWebDriver driver;

    [SetUp]
    public void Setup()
    {
        driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
         driver.Url = "https://the-internet.herokuapp.com/javascript_alerts";
       // driver.Url = "https://letcode.in/alert";
    }

    [Test]
    public void Test1()
    {
            //IWebElement ClickForJsAlert = driver.FindElement(By.XPath("//button[text()='Click for JS Alert']"));
            //ClickForJsAlert.Click();
            //driver.SwitchTo().Alert().Accept();
            //// Click for JS Confirm

            //IWebElement ClickforJSConfirm = driver.FindElement(By.XPath("//button[text()='Click for JS Confirm']"));
            //ClickforJSConfirm.Click();
            //// Thread.Sleep(2000);
            //driver.SwitchTo().Alert().Accept();
            //ClickforJSConfirm.Click();
            //// Thread.Sleep(2000);
            //driver.SwitchTo().Alert().Dismiss();

            IWebElement ClickforJSPrompt = driver.FindElement(By.XPath("//button[text()='Click for JS Prompt']"));
            ClickforJSPrompt.Click();
            Thread.Sleep(2000);
            driver.SwitchTo().Alert().SendKeys("I am a prompt");
            driver.SwitchTo().Alert().Accept();

            //IWebElement ClickforJSConfirm = driver.FindElement(By.XPath("//button[text()='Click for JS Confirm']"));
            //ClickforJSConfirm.Click();
            //// Thread.Sleep(2000);
            //string alertText = driver.SwitchTo().Alert().Text;
            //Assert.That(alertText.Equals("I am a JS Confirm"));

            //Window Handles
        }
    }
}
