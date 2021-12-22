using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using NUnit.Allure.Core;
using NUnit.Allure.Steps;
using Allure.Commons;

namespace QA_testing_project
{
    public class TestBase
    {
        public static IWebDriver driver { get; set; }
        public string BaseUrl = "http://20.50.171.10:8080/";
        public enum BrowserTypes
        {
            Chrome,
            Firefox
        }
        public BrowserTypes browserType;
        public TestBase(BrowserTypes browser)
        {
            browserType= browser;
        }

        



        [SetUp]
        /* public void Setup()
         {
             var additionalSelenoidCapabilities = new Dictionary<string, object>();
             additionalSelenoidCapabilities.Add("name", "Simple test");
             additionalSelenoidCapabilities.Add("enableVNC", true);
             additionalSelenoidCapabilities.Add("enableVideo", true);

             var chromeOptions = new ChromeOptions();
             chromeOptions.AddAdditionalCapability("selenoid:options", additionalSelenoidCapabilities, true);
             driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), chromeOptions.ToCapabilities());
             driver.Url = BaseUrl;
             driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
         }
        */
        public void Setup() 
        {
            ChooseBrowser(browserType);

            driver.Manage().Window.Size = new System.Drawing.Size(1552, 840);
            driver.Navigate().GoToUrl(BaseUrl);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(180);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(500);
            driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(500);

        }
        public void ChooseBrowser(BrowserTypes browserType)
        {

            var additionalSelenoidCapabilities = new Dictionary<string, object>();
            additionalSelenoidCapabilities.Add("name", "Simple test");
            additionalSelenoidCapabilities.Add("enableVNC", true);
            additionalSelenoidCapabilities.Add("enableVideo", true);


            switch (browserType)
            {
                case BrowserTypes.Chrome:
                    var chrome_options = new ChromeOptions();
                    chrome_options.AddAdditionalOption("selenoid:options", additionalSelenoidCapabilities);
                    driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), (new ChromeOptions()).ToCapabilities());
                    break;
                case BrowserTypes.Firefox:
                    var firefox_options = new FirefoxOptions();
                    firefox_options.AddAdditionalOption("selenoid:options", additionalSelenoidCapabilities);
                    driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), (new FirefoxOptions()).ToCapabilities());
                    break;
                default:
                    driver = new ChromeDriver(@"\\driver");
                    break;
            }
        }



        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                var filename = TestContext.CurrentContext.Test.MethodName + "_screenshot_" + DateTime.Now.Ticks + ".png";
                var path = $"F:\\{filename}";
                screenshot.SaveAsFile(path, ScreenshotImageFormat.Png);
           //     AllureLifecycle.Instance.AddAttachment(filename, "image/png", path);
            }
            
            driver.Quit();
        }
    }
}
