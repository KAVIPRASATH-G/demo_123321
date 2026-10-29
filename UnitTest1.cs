
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumCSharpDemo;

public class UnitTest1
{
    private IWebDriver driver = null!;

    [SetUp]
    public void Setup()
    {
        driver = new ChromeDriver();
    }

    [Test]
    public void OpenSeleniumWebsite()
    {
        driver.Navigate().GoToUrl(
            "https://www.selenium.dev/"
        );

       
    }

    [TearDown]
    public void Cleanup()
    {
        driver?.Quit();
        driver?.Dispose();
    }
}
