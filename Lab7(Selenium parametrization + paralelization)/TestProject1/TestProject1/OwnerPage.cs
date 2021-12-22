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
    public class OwnerPage : page_object
     {
       
        public OwnerPage(IWebDriver driver) : base(driver) { }


        public NavigationComponent NavigationComponent => new NavigationComponent(driver);

        [AllureStep("Opens Owner Create Page")]
        public void OpenOwnerPage()
        {
            driver.FindElement(By.CssSelector(".ownerTab")).Click();
            driver.FindElement(By.CssSelector(".open li:nth-child(2) > a")).Click();
        }
       [AllureStep("Enters Firt Name value")]
        public void ChangeFirstNameValue(string value, bool overwrite = true) => ChangeInputValue(By.Id("firstName"), value, overwrite);
        
        [AllureStep("Enters Last Name value")]
        public void ChangeLastNameValue(string value, bool overwrite = true) => ChangeInputValue(By.Id("lastName"), value, overwrite);

        [AllureStep("Enters Address value")]
        public void ChangeAddressValue(string value, bool overwrite = true) => ChangeInputValue(By.Id("address"), value, overwrite);

        [AllureStep("Enters City value")]
        public void ChangeCityValue(string value, bool overwrite = true) => ChangeInputValue(By.Id("city"), value, overwrite);

        [AllureStep("Enters Telephone Value")]
        public void ChangeTelephoneValue(string value, bool overwrite = true) => ChangeInputValue(By.Id("telephone"), value, overwrite);

        [AllureStep("Creates new Owner record")]
        public void ClickOnCreateButton() => driver.FindElement(By.CssSelector(".addOwner")).Click();


    }
}
