using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumClasses
{
    internal class FindElementById
    {

        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://the-internet.herokuapp.com/";
        }

        [Test]
        public void BrowserBack()
        {
            IWebElement link =  driver.FindElement(By.LinkText("Form Authentication"));
            link.Click();
            
            IWebElement username = driver.FindElement(By.Id("username"));
            username.SendKeys("tomsmith");
            
            IWebElement password = driver.FindElement(By.Name("password"));
            password.SendKeys("SuperSecretPassword!");

            driver.FindElement(By.TagName("button")).Click();

            IWebElement flashMessage = driver.FindElement(By.Id("flash"));
            string flashmsg = flashMessage.Text;

            Assert.That(flashmsg.Contains("You logged into a secure area!"));
        }

        [TearDown]
        public void CloseDriver()
        {
            driver.Close();

        }
    }
}
