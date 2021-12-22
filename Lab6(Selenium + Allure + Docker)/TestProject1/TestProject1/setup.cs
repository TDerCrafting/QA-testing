using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework.Interfaces;
using Allure.Commons;
using OpenQA.Selenium.Remote;

namespace QA_testing_project
{
    public class TestBase
    {
        public static IWebDriver driver;
        public string BaseUrl = "http://20.50.171.10:8080/";

        [SetUp]
        public void Setup()
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
