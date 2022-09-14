using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;

namespace SeleniumClasses
{
    public class Tests
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
        public void Test1()
        {                      
            IWebElement gmail = driver.FindElement(By.XPath("//a[text()='Gmail']"));
            gmail.Click();
            string title = driver.Title;
            Assert.That(title.Equals("Gmail: Private and secure email at no cost | Google Workspace"));
        }

        [Test]
        public void Test2()
        {                    
            IWebElement images = driver.FindElement(By.XPath("//a[text()='Images']"));
            images.Click();
            string title = driver.Title;
            Assert.That(title.Equals("Google Images"));

        }
    }
}

// Selenium - Only automate browser, it is not a testing tool
// WebDriverManager - another nuget to help manage browser
// Nunit - test framework