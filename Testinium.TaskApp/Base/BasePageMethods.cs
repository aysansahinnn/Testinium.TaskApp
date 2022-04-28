using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.IO;
using System.Security.AccessControl;
using System.Threading;

namespace TestDeneme.Base
{
    public class BasePageMethods
    {
        private readonly IWebDriver _driver;

        string folder;
        string path;
        DirectoryInfo filepath;
        public BasePageMethods(IWebDriver webDriver)
        {
            _driver = webDriver;

            folder = Directory.GetCurrentDirectory() + @"/logs";
            path = Guid.NewGuid().ToString();
            filepath = Directory.CreateDirectory($"{folder}/{path}");
        }
        public void FindElement(string name, string sendKey)
        {
            _driver.FindElement(By.Name(name)).SendKeys(sendKey);
        }

        public void ScrollDown()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)_driver;
            js.ExecuteScript("window.scrollBy(0,350)", "");
            //js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
            Thread.Sleep(5000);
        }

        public void FindElementXPath(string url)
        {
            _driver.FindElement(By.XPath(url)).Click();
        }
  
        public string GetProductName(string productName)
        {
            string name = _driver.FindElement(By.XPath(productName)).Text;
            return name;
        }
        public string GetProductAmount(string productAmount)
        {
            string amount = _driver.FindElement(By.XPath(productAmount)).Text;
            return amount;
        }
        public void GetCompareProduct(string basketAmount, string productAmount)
        {
            StringAssert.Contains(basketAmount, productAmount);
        }
        public void DeleteFromBasketProduct(string basketResult, string message)
        {
            StringAssert.Contains(basketResult, message);
        }
        public string GetBoxResult(string basketResult)
        {
            string amount = _driver.FindElement(By.XPath(basketResult)).Text;
            return amount;
        }
        public void Duration()
        {
            Thread.Sleep(3000);
        }

        public void FileLog(string productName, string productAmount)
        {
            TextWriter tw = new StreamWriter(filepath.FullName + ".txt");
            tw.WriteLine("ProductName= " + productName);
            tw.WriteLine("ProductAmount= " + productAmount);
            tw.Close();

        }
    }
}
