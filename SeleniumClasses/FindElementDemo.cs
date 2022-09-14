using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace SeleniumClasses
{
    internal class FindElementDemo
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
            IWebElement gmail = driver.FindElement(By.Id("username"));
            gmail.SendKeys("jsgf");

            IWebElement ByName = driver.FindElement(By.Name("username"));

            IWebElement ByClassname = driver.FindElement(By.ClassName("radius"));

            IWebElement ByTagname = driver.FindElement(By.TagName("input"));

            IWebElement ByLinkText = driver.FindElement(By.LinkText("Elemental Selenium"));

            IWebElement ByPartialText = driver.FindElement(By.PartialLinkText("Elemental"));

            IWebElement ByXpath = driver.FindElement(By.XPath("//input[@name='username']"));

            IWebElement Bycss = driver.FindElement(By.CssSelector("//input[@name='username']"));

            IReadOnlyCollection<IWebElement> Bycss1 = driver.FindElements(By.TagName("a"));

            //FindElement()

            // No Match : throw NoSuch Element Exception found
            // Single match : returns WebElement
            // multiple matches : pick up the first element

            //FineElements()

            //No Match: return an empty list
            //One Match: return list of one weblement only
            // multiple matches: return list of webelements



            // Assert.That(title.Equals("Gmail: Private and secure email at no cost | Google Workspace"));
        }
    }
}
