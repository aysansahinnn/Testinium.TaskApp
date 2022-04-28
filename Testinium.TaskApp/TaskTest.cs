using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestDeneme
{
    [TestClass]
    public class TaskTest : Base.BaseTestMethods
    {
        private string productName;
        private string productAmount;
        private string basketAmount;
        private string boxResult;
     
        [TestMethod]
        public void TestMethod()
        {
            Base.BasePageMethods basePage = new Base.BasePageMethods(TaskTest.GetWebDriver());

            basePage.FindElement(Costants.Costants.Name, Costants.Costants.SendKey);
            basePage.FindElementXPath(Costants.Costants.SearchProduct);
            basePage.Duration();

            basePage.ScrollDown();
            basePage.Duration();

            basePage.FindElementXPath(Costants.Costants.PopUpDismiss);
            basePage.Duration();

            basePage.FindElementXPath(Costants.Costants.SecondPage);
            basePage.Duration();


            basePage.FindElementXPath(Costants.Costants.FindProduct);

            basePage.FindElementXPath(Costants.Costants.AddToBasket);
            basePage.Duration();

            productName = basePage.GetProductName(Costants.Costants.ProductName);
            productAmount = basePage.GetProductAmount(Costants.Costants.ProductAmount);
            basePage.Duration();

            basePage.FileLog(productName, productAmount);

            basePage.FindElementXPath(Costants.Costants.GoToBasket);
            basketAmount = basePage.GetProductAmount(Costants.Costants.ProductBasketAmount);
            basePage.GetCompareProduct(basketAmount, productAmount);
            basePage.Duration();

           
            basePage.FindElementXPath(Costants.Costants.AmountPlus);
            basePage.Duration();


            basePage.FindElementXPath(Costants.Costants.DeleteProduct);
            basePage.Duration();

            boxResult = basePage.GetBoxResult(Costants.Costants.BoxResult);
            basePage.DeleteFromBasketProduct(boxResult, Costants.Costants.Message);
            basePage.Duration();

            TaskTest.TearnDown();

        }

    }
}
