using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;


namespace SeleniumQuizPro
{
    [TestClass]
    public class BasePage

    {
        public static readonly log4net.ILog log =

log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public static IWebDriver driver;

        public void SeleniumInit()
        {
            IWebDriver ChromeDriver = new ChromeDriver();
            driver = ChromeDriver;
            driver.Url = "http://automationexercise.com/";
            driver.Manage().Window.Maximize();
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("Test1.png", ScreenshotImageFormat.Png);
            log.Info("Browser is Openend");

        }
        public void Screenshot()
        {
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("Test1.png", ScreenshotImageFormat.Png);
        }
        public void DriverClose()
        {
            log.Info("Process has been successful");
            driver.Close();
        }
    }
}
