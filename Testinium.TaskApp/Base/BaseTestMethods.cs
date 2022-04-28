using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestDeneme.Base
{
    public class BaseTestMethods
    {
        protected static IWebDriver webDriver = null;

        [SetUp]
        public static IWebDriver GetWebDriver()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--disable-popup-blocking");
            webDriver = new ChromeDriver(chromeOptions);
            webDriver.Manage().Window.Maximize();
            webDriver.Url = ("http://www.gittigidiyor.com");

            return webDriver;
        }

        [TearDown]
        public static IWebDriver TearnDown()
        {
            webDriver.Quit();
            return webDriver;
        }
    }

}
