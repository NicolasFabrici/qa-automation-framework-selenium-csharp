using OpenQA.Selenium;
using QAFramework.Utilities;

namespace QAFramework.Pages
{
    public class GooglePage : BasePage
    {
        private By searchBox = By.Name("q");

        public GooglePage(IWebDriver driver) : base(driver)
        {
        }

        public void Navigate()
        {
            driver.Navigate().GoToUrl(ConfigReader.BaseUrl);
        }

        public void Search(string text)
        {
            Type(searchBox, text);
        }

        public string GetTitle()
        {
            return driver.Title;
        }
    }
}