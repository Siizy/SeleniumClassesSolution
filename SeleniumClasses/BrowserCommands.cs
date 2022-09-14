using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumClasses
{
    internal class BrowserCommands
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.google.com";
        }

        [Test]
        public void BrowserBack()
        {
            IWebElement gmail = driver.FindElement(By.XPath("//a[text()='Gmail']"));
            gmail.Click();
            driver.Navigate().Back();
            string title = driver.Title;           
            Assert.That(title.Equals("Google"));                     
        }

        [Test]
        public void BrowserForward()
        {
            IWebElement gmail = driver.FindElement(By.XPath("//a[text()='Gmail']"));
            gmail.Click();
            driver.Navigate().Back();
            gmail = driver.FindElement(By.XPath("//a[text()='Gmail']"));
            gmail.Click();
            driver.Navigate().Forward();
            string title = driver.Title;
            Assert.That(title.Equals("Gmail: Private and secure email at no cost | Google Workspace"));           
        }

        [Test]
        public void BrowserRefresh()
        {
            IWebElement gmail = driver.FindElement(By.XPath("//a[text()='Gmail']"));
            gmail.Click();
            driver.Navigate().Refresh();
            string title = driver.Title;
            Assert.That(title.Equals("Gmail: Private and secure email at no cost | Google Workspace"));
        }

        [TearDown]
        public void CloseDriver()
        {
            driver.Close();

        }
    }
}
