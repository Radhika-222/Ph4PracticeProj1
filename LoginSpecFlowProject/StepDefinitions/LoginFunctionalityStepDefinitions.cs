using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using TechTalk.SpecFlow;

namespace LoginSpecFlowProject.StepDefinitions
{
    [Binding]
    public class LoginFunctionalityStepDefinitions
    {
        private IWebDriver _driver;
        [Given(@"I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {

            _driver = new EdgeDriver();
            _driver.Navigate().GoToUrl("http://localhost:43117/Login/Login");
        }

        [When(@"I enter valid credentials")]
        public void WhenIEnterValidCredentials()
        {
            _driver.FindElement(By.Id("username")).SendKeys("validUsername");
            _driver.FindElement(By.Id("password")).SendKeys("validPassword");
            _driver.FindElement(By.TagName("button")).Click();
        }

        [When(@"I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            _driver.FindElement(By.Id("Login")).Click();
        }

        [Then(@"I should be redirected to the dashboard page")]
        public void ThenIShouldBeRedirectedToTheDashboardPage()
        {
            Assert.Equal("http://localhost:43117/Login/Dashboard", _driver.Url); 
            _driver.Quit();
        }
    }
}
