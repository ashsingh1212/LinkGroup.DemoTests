using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.ObjectModel;
using TechTalk.SpecFlow;

namespace LinkGroup.DemoTests
{
    [Binding]
    public class BrowserContext
    {
        public static IWebDriver driver;

        public static IWebElement Find(By by)
        {
            return driver.FindElement(by);
        }

        public static ReadOnlyCollection<IWebElement> GetElements(By by)
        {
            ReadOnlyCollection<IWebElement> e = null;
            e = driver.FindElements(by);
            return e;
        }

        [BeforeScenario]
        public static void Initialise()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [AfterScenario]
        public static void Dispose()
        {
            driver.Close();
            driver.Quit();
        }
    }
}