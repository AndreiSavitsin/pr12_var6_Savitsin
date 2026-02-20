using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr12_var6_Savitsin
{
    public class Buyer
    {
        private string NameProduct;
        private double PriceProduct;
        private int CountProduct;
        private double Wallet;
        private int Mood = 10;

        //Получаем название продукта
        public string GetName()
        {
            return NameProduct;
        }
        //Получаем стоимость продукта
        public double GetPrice()
        {
            return PriceProduct;
        }
        //Получаем количество 
        public int GetCount()
        {
            return CountProduct;
        }
        //Получаем кошелёк
        public double GetWallet()
        {
            return Wallet;
        }
        //Получаем настроение
        public int GetMood()
        {
            return Mood;
        }
        //Метод дял отображения информации о покупке
        public string GetBuyInfo()
        {

        }
    }
}
