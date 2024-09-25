using OpenQA.Selenium;
using SpecFlowBDDFramework.Utility;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowBDDFramework.StepDefinitions
{
    [Binding]
    public class AdminApproveStepDefinitions
    {
        private IWebDriver driver;
        private string adminEmail = ConfigReader.GetInstance().GetAnyPropValue("adminlogin");
        private string adminPass = ConfigReader.GetInstance().GetAnyPropValue("adminpass");
        public AdminApproveStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }
        [Given(@"Admin go to home page")]
        public void GivenAdminGoToHomePage()
        {
            driver.Url = ConfigReader.GetInstance().GetBaseUrl();
        }

        [When(@"Admin login to his account")]
        public void WhenAdminLoginToHisAccount()
        {
            IWebElement btnlogin = driver.FindElement(By.CssSelector("a.ico-login"));
            btnlogin.Click();
            IWebElement txtAdminEmail = driver.FindElement(By.Id("Email"));
            txtAdminEmail.Clear();
            txtAdminEmail.SendKeys(adminEmail);
            Thread.Sleep(2000);
            IWebElement txtAdminPass = driver.FindElement(By.Id("Password"));
            txtAdminPass.Clear();
            txtAdminPass.SendKeys(adminPass);
            Thread.Sleep(2000);
            IWebElement btnLogin = driver.FindElement(By.XPath("//button[@class='button-1 login-button']"));
            btnLogin.Submit();
            Thread.Sleep(3000);
        }

        [Then(@"Admin approve to his account")]
        public void ThenAdminApproveToHisAccount()
        {
            IWebElement btnAdministrator = driver.FindElement(By.XPath("//a[normalize-space(text())='Administration']"));
            btnAdministrator.Click();
            Thread.Sleep(3000);
            IWebElement drpdwnCustomer = driver.FindElement(By.XPath("/html/body/div[3]/aside/div/div[4]/div/div/nav/ul/li[4]/a"));
            drpdwnCustomer.Click();
            Thread.Sleep(1000);
            IWebElement clickCustomer = driver.FindElement(By.XPath("/html/body/div[3]/aside/div/div[4]/div/div/nav/ul/li[4]/ul/li[1]/a"));
            clickCustomer.Click();
            Thread.Sleep(3000);
            IWebElement btnedit = driver.FindElement(By.XPath("//table[@id='customers-grid']/tbody[1]/tr[1]/td[8]/a[1]"));
            btnedit.Click();
            Thread.Sleep(3000);
            IWebElement btnactive = driver.FindElement(By.Id("Active"));
            btnactive.Click();
            Thread.Sleep(2000);
            IWebElement btnsave = driver.FindElement(By.Name("save"));
            btnsave.Click();
            Thread.Sleep(3000);
        }
    }
}
