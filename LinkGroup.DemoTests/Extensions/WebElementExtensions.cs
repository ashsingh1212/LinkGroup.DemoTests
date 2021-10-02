using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using static LinkGroup.DemoTests.BrowserContext;

namespace LinkGroup.DemoTests.Extensions
{
    public static class WebElementExtensions
    {
        public static void Click(By element)
        {
            var IElement = Find(element);
            IElement.Click();
        }

        public static void InputValue(By element, string value)
        {
            var IElement = Find(element);
            IElement.SendKeys(value);
        }

        public static void NavigateToUrl(string url)
        {
            driver.Url = url;
        }

        public static void AssertPageTitleIsCorrect(string value)
        {
            var pageTitle = driver.Title;
            Assert.AreEqual(value, pageTitle);
        }

        public static void AssertElementContainsText(By element, string value)
        {
            var IElement = Find(element).Text.Replace(Environment.NewLine, " ");
            Assert.IsTrue(IElement.Contains(value), $"Expected value was {value} but actual was {IElement}");
        }

        public static void HoverOverElement(By element)
        {
            var IElement = Find(element);
            Actions action = new Actions(driver);
            action.MoveToElement(IElement).Perform();
        }

        public static void AssertElementIsVisible(By element)
        {
            var IElement = Find(element);
            Assert.IsTrue(IElement.Displayed);
        }
    }
}