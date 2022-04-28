using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDeneme.Costants
{
    public class Costants
    {
        public static string Name => "k";
        public static string SendKey => "bilgisayar";
        public static string SearchProduct => "//button[@data-cy='search-find-button']";
        public static string SecondPage => "//a[@role='button' and @aria-label='2. sayfa']";
        public static string PopUpDismiss => "//a[@class='tyj39b-5 bEEsJG']";
        public static string FindProduct => "//article[@data-cy='product-card-item'][1]//div[2]//a[1]";
        public static string AddToBasket => "//button[@id='add-to-basket']";
        public static string ProductName => "//h1[@id='sp-title']";
        public static string ProductAmount => "//div[@id='sp-price-lowPrice'][1]";
        public static string GoToBasket => "//a[@href='https://www.gittigidiyor.com/sepetim']";
        public static string ProductBasketAmount => "//div[@class='total-price']//strong";
        public static string DeleteProduct => "//a[@title='Sil'][1]";
        public static string AmountPlus => "//div[@class='gg-input gg-input-select ']//select//option[@value='2']"; 
        public static string BoxResult => "//div[@class='gg-d-19 gg-w-21 gg-t-19 gg-m-18']//h2";
        public static string Message => "Sepetinizde ürün bulunmamaktadır.";

    }
}
