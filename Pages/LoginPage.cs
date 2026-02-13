using OpenQA.Selenium;

namespace QAFramework.Pages
{
    public class LoginPage : BasePage
    {
        private By usernameInput = By.Id("username");
        private By passwordInput = By.Id("password");
        private By loginButton = By.CssSelector("button[type='submit']");

        public LoginPage(IWebDriver driver) : base(driver) { }

        public void EnterUsername(string username)
        {
            driver.FindElement(usernameInput).SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            driver.FindElement(passwordInput).SendKeys(password);
        }

        public void ClickLogin()
        {
            driver.FindElement(loginButton).Click();
        }
    }
}