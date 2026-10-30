using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.Extensions;

namespace seleniumCSharpDemo.Utilities
{
    public static class CommonMethods
    {
        public static void EnterKeys(IWebDriver driver, By locator, string text)
        {
            IWebElement element = driver.FindElement(locator);
            element.SendKeys(text);
        }
        public static void WaitForElementToBeVisible(IWebDriver driver, By locator, int timeoutInSeconds = 10)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            wait.Until(d => d.FindElement(locator).Displayed);
        }

        public static void WaitForElementToBeClickable(IWebDriver driver, By locator, int timeoutInSeconds = 10)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            wait.Until(d => d.FindElement(locator).Enabled);
        }

    }
}