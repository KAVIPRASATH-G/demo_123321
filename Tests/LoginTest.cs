using NUnit.Framework;
using OpenQA.Selenium;
using seleniumCSharpDemo.Pages;

namespace seleniumCSharpDemo.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
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
            loginPage.Login("username2", "password2");

            // Verify successful login
            Assert.That(
                driver.Title.Contains("Dashboard"),
                "Login failed. Dashboard title was not found."
            );
        }
    }
}