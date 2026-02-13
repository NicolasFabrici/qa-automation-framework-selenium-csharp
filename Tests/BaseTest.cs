using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using QAFramework.Utilities;
using OpenQA.Selenium.Edge;

namespace QAFramework.Tests
{
    public class BaseTest
    {
        protected IWebDriver driver;

        [SetUp]
    public void SetUp()
    {
        string browser = ConfigReader.Browser;

        switch (browser.ToLower())
        {
            case "chrome":
                var chromeOptions = new ChromeOptions();
                chromeOptions.AddArgument("--start-maximized");
                driver = new ChromeDriver(chromeOptions);
                break;

            case "edge":
                var edgeOptions = new EdgeOptions();
                edgeOptions.AddArgument("start-maximized");
                driver = new EdgeDriver(edgeOptions);
                break;

            default:
                throw new Exception("Browser not supported");
        }

        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(ConfigReader.Timeout);
    }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}