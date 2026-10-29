using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using seleniumCSharpDemo.Pages;

public class Tests
{
    private IWebDriver driver;
    private LoginPage loginPage;

    [SetUp]
    public void Setup()
    {
        driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        LoginPage loginPage = new LoginPage(driver);
    }

    [Test]
    public void LoginScenario()
    {
       
        loginPage.NavigateToLoginPage();
        loginPage.EnterUsername("testuser");
        loginPage.EnterPassword("password");
        loginPage.ClickSubmitButton();

        // Add assertions to verify successful login
    }

    [TearDown]
    public void TearDown()
    {
        if (driver != null)
        {
            driver.Quit();
            driver.Dispose();
        }

    }
}