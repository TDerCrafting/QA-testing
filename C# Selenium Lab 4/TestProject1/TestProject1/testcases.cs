// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
namespace QA_testing_project
{
    public class Testcases : TestBase
    {
        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;


        [Test]
        public void testcase1()
        {

            var pageObject = new OwnerPage(driver);
            pageObject.OpenOwnerPage();
            pageObject.ChangeFirstNameValue("Alex");
            pageObject.ChangeLastNameValue("petrov");
            pageObject.ChangeAddressValue("perkov");
            pageObject.ChangeCityValue("tarkov");
            pageObject.ChangeTelephoneValue("880083");
            pageObject.ClickOnCreateButton();

          /*  driver.Navigate().GoToUrl("http://20.50.171.10:8080//");
            driver.Manage().Window.Size = new System.Drawing.Size(816, 766);
            driver.FindElement(By.CssSelector(".ownerTab")).Click();
            driver.FindElement(By.CssSelector(".open li:nth-child(2) > a")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Maks");
            driver.FindElement(By.Id("lastName")).Click();
            driver.FindElement(By.Id("lastName")).SendKeys("Nikolaichuk");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).SendKeys("asd");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).SendKeys("asdasd");
            driver.FindElement(By.Id("telephone")).Click();
            driver.FindElement(By.Id("telephone")).SendKeys("1234124512");
            driver.FindElement(By.CssSelector(".addOwner")).Click();
            driver.Close();*/
        }

        [Test]
        public void testcase2()
        {
            var pageObject = new VetPage(driver);
            pageObject.OpenVetPage();
            pageObject.ClickOnDeleteButton();
           /* driver.Navigate().GoToUrl("http://20.50.171.10:8080//");
            driver.Manage().Window.Size = new System.Drawing.Size(1050, 840);
            driver.FindElement(By.CssSelector(".vetsTab")).Click();
            driver.FindElement(By.CssSelector(".open li:nth-child(1) > a")).Click();
            driver.FindElement(By.CssSelector("tr:nth-child(1) .deleteVet")).Click();
            driver.Close();*/

        }

        [Test]
        public void testcase3()
        {

            var pageObject = new PetTypesPage(driver);
            pageObject.OpenPetTypesPage();
            pageObject.ClickOnDeleteTypeButton();
            /*driver.Navigate().GoToUrl("http://20.50.171.10:8080//");
            driver.Manage().Window.Size = new System.Drawing.Size(1050, 840);
            driver.FindElement(By.CssSelector("li:nth-child(4) > a")).Click();
            driver.FindElement(By.CssSelector("tr:nth-child(1) .deletePet")).Click();
            driver.Close();*/
        }
    }
}