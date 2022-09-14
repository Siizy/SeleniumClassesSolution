using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {


            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://letcode.in/alert";

            driver.FindElement(By.XPath("//*[text()='Simple Alert']")).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().Alert().Accept();
            
            driver.FindElement(By.XPath("//*[text()='Confirm Alert']")).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().Alert().Dismiss();
            
            driver.FindElement(By.XPath("//*[text()='Prompt Alert']")).Click();
            driver.SwitchTo().Alert().SendKeys("Accepting the alert");
            Thread.Sleep(2000);
            driver.SwitchTo().Alert().Accept();
            
            driver.FindElement(By.XPath("//*[text()='Modern Alert']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//button[@aria-label='close']")).Click();
            driver.Quit();
        }
    }
}

