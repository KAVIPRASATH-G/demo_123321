using NUnit.Framework;
using OpenQA.Selenium;
using seleniumCSharpDemo.Pages;

namespace seleniumCSharpDemo.Tests
{
    [TestFixture]
    public class LoginTest : BaseTest
    {
        private LoginPage loginPage;

        [SetUp]
        public void LoginSetup()
        {
            loginPage = new LoginPage(driver);
        }

        [Test]
        public void LoginScenario()
        {
            // Perform login
            loginPage.Login("username", "password");

            // Verify successful login
            Assert.That(
                driver.Title.Contains("Dashboard"),
                "Login failed. Dashboard title was not found."
            );
        }
    }
}