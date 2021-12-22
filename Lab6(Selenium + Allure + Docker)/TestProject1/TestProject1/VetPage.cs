using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using NUnit.Allure.Attributes;

namespace QA_testing_project
{
    public class VetPage : page_object
     {
       
        public VetPage(IWebDriver driver) : base(driver) { }

        public NavigationComponent NavigationComponent => new NavigationComponent(driver);

        [AllureStep("Opens Veterinarians page")]
        public void OpenVetPage()
        {
            driver.FindElement(By.CssSelector(".vetsTab")).Click();
            driver.FindElement(By.CssSelector(".open li:nth-child(1) > a")).Click();
        }

        
        [AllureStep("Deletes first record at page Veterinarians")]
        public void ClickOnDeleteButton() => driver.FindElement(By.CssSelector("tr:nth-child(1) .deleteVet")).Click();


    }
}
