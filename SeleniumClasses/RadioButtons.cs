using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace SeleniumClasses
{
    internal class RadioButtons
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://css-tricks.com/examples/RadioGrid/";
        }

        [Test]
        public void SelectRadioButton()
        {
          Thread.Sleep(3000);
          IWebElement radioButton   =  driver.FindElement(By.XPath("//*[@id='page-wrap']/table/tbody/tr[2]/td[2]/input"));
          radioButton.Click();
            // Assert.That(title.Equals("Google"));
        }



    }
}
