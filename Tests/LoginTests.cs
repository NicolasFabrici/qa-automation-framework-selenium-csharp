using NUnit.Framework;
using QAFramework.Pages;

namespace QAFramework.Tests
{
    public class LoginTests : BaseTest
    {
        [Test]
        public void SearchInGoogleTest()
        {
            var googlePage = new GooglePage(driver);

            googlePage.Navigate();
            googlePage.Search("QA Automation");

            Assert.That(googlePage.GetTitle(), Does.Contain("Google"));
        }
    }
}