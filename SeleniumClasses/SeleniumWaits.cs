using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumClasses
{
    internal class SeleniumWaits
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
           // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://the-internet.herokuapp.com/dynamic_controls";
        }

         [Test]
        public void ThreadSleepTest() 
        {
            //Click on Remove
            IWebElement removeButton = driver.FindElement(By.XPath("//button[text()='Remove']"));
            removeButton.Click();

            //Add wait of 5 seconds
            Thread.Sleep(15000);

            //Click on Add
            IWebElement addButton = driver.FindElement(By.XPath("//button[text()='Add']"));
            addButton.Click();

        }

         [Test]
        public void ImplicitWaitTest()
        {
            //Click on Remove
            IWebElement removeButton = driver.FindElement(By.XPath("//button[text()='Remove']"));
            removeButton.Click();

            //Click on Add
            IWebElement addButton = driver.FindElement(By.XPath("//button[text()='Add']"));
            addButton.Click();

        }

        [Test]
        public void ExplicitWebDriverWaitTest()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));

            //Click on Remove
            IWebElement removeButton = driver.FindElement(By.XPath("//button[text()='Remove']"));
            removeButton.Click();

            //Click Add 
            IWebElement addButton = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//button[text()='Add']")));
            addButton.Click();

             IWebElement msg = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//p[@id='message']")));
            // IWebElement msg = driver.FindElement(By.XPath("//p[@id='message']"));
            Assert.That(msg.Text.Equals("It's back!"));
        }

        [Test]
        public void ExplicitDefaultWaitTest()
        {
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);

            fluentWait.Timeout = TimeSpan.FromSeconds(5);

            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(500);

            /* Ignore the exception - NoSuchElementException that indicates that the element is not present */

            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));

            fluentWait.Message = "Element to be searched not found";
          
            driver.FindElement(By.XPath("//button[text()='Enable']")).Click();
            IWebElement EnableDisable = fluentWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//form/input[not(@disabled)]")));
            EnableDisable.SendKeys("test");


        }
    }
}
