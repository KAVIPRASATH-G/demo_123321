
using OpenQA.Selenium;

namespace seleniumCSharpDemo.Pages
{
    public class HomePage
    {
        private readonly IWebDriver driver;
        private readonly By usernameField = By.Id("username");
        private readonly By passwordField = By.Id("password");
        private readonly By submitButton = By.Id("submit");

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void EnterUsername(string username)
        {
            driver.FindElement(usernameField).SendKeys(username);
        }
        {
            
        public void EnterPassword(string password)
        {
            driver.FindElement(passwordField).SendKeys(password);
        }

        public void ClickSubmitButton()
        {
            driver.FindElement(submitButton).Click();
        }

        public string GetTitle()
        {
            return driver.Title;
        }
    }
}
