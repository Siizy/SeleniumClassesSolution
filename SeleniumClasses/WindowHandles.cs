
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SeleniumClasses
{
    internal class WindowHandles
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://demoqa.com/browser-windows";
        }

        [Test]
        public void Test1()
        {
            string parentHandle = driver.CurrentWindowHandle;
            
            for (int i = 0; i < 3; i++)
            {
                driver.FindElement(By.Id("windowButton")).Click();
            }

            List<string> listHandles = driver.WindowHandles.ToList();

            foreach (string handle in listHandles) 
            {
                if (handle!= parentHandle) {
                    TestContext.Out.WriteLine(handle);
                    driver.SwitchTo().Window(handle);
                    driver.Navigate().GoToUrl("https://www.google.com");
                    driver.Close();
                }
                
            }

            driver.SwitchTo().Window(parentHandle);
            driver.FindElement(By.Id("tabButton")).Click();
                     
        }       
    }
}
