using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace QA_testing_project
{
    public class TestBase
    {
        public static IWebDriver driver;
        public string BaseUrl = "http://20.50.171.10:8080/";

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver("driver");
            driver.Url = BaseUrl;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
