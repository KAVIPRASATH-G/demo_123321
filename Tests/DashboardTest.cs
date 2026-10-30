using NUnit.Framework;
using OpenQA.Selenium;
using seleniumCSharpDemo.Pages;

namespace seleniumCSharpDemo.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class DashboardTest : BaseTest
    {
        private LoginPage loginPage;

        [SetUp]
        public void DashboardSetup()
        {
            loginPage = new LoginPage(driver);
        }

        [Test]
        public void VerifyDashboardAfterLogin()
        {
            // Step 1: Login
            loginPage.Login("username1", "password1");

            Assert.That(
                driver.Title.Contains("Dashboard"),
                "Dashboard page was not displayed."
            );

        }
    }
}