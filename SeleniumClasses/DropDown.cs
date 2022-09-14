using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumClasses
{
    internal class DropDown
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://the-internet.herokuapp.com/dropdown";
        }

        [Test]
        public void SelectDropDownValue()
        {
           IWebElement dropdown = driver.FindElement(By.Id("dropdown"));
           SelectElement select = new SelectElement(dropdown);
            // select.SelectByIndex(1);
            // select.SelectByText("Option 2");
            // select.SelectByValue("2");
            IList<IWebElement> allOptions = select.Options;

            for (int i = 0; i > allOptions.Count; i++)
            {
                string ddvalue = allOptions.ElementAt(i).Text;
               // Console.WriteLine(ddvalue);
                TestContext.Out.WriteLine(ddvalue);
            }
        }
    }
}
