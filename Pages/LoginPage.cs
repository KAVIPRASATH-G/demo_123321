using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using seleniumCSharpDemo.Utilities;

namespace seleniumCSharpDemo.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver driver;

        private readonly By usernameField = By.Id("txtUsername");
        private readonly By passwordField = By.Id("txtPassword");
        private readonly By submitButton = By.Id("submitt");

        private readonly WebDriverWait wait;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public void NavigateToLoginPage()
        {
            driver.Navigate().GoToUrl(
                "https://staging.cloud.jobpac.com.au/");
        }

        public void VerifyLoginPageTitle()
        {
            wait.Until(d => d.FindElement(usernameField).Displayed);
        }

        public void EnterUsername(string username)
        {

            CommonMethods.EnterKeys(driver, usernameField, username);
        }

        public void EnterPassword(string password)
        {

            CommonMethods.EnterKeys(driver, passwordField, password);
        }

        public void ClickSubmitButton()
        {

            driver.FindElement(submitButton).Click();
        }

        // Reusable Login Method
        public void Login(string username, string password)
        {
            NavigateToLoginPage();
            VerifyLoginPageTitle();
            EnterUsername(username);
            EnterPassword(password);
            ClickSubmitButton();
        }
    }
}
