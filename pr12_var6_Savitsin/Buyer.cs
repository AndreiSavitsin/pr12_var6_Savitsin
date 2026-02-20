using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr12_var6_Savitsin
{
    internal class Buyer
    {
        private string NameProduct;
        private double PriceProduct;
        private int CountProduct;
        private double Wallet;
        private int Mood = 10;

        //Конструктор
        public Buyer(string nameProduct, double priceProduct, int countProduct, double wallet)
        {
            NameProduct = nameProduct;
            PriceProduct = priceProduct;
            CountProduct = countProduct;
            Wallet = wallet;
        }

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
        //Метод для отображения информации о покупке
        public string GetBuyInfo()
        {
            double totalCost = PriceProduct * CountProduct;
            return $"Продукт: {NameProduct}\n" + $"Количество: {CountProduct}\n" + $"Стоимость покупки: {totalCost}";
        }
        //Метод - купить
        public string Buy()
        {
            double totalCost = PriceProduct * CountProduct;
            string message;
            if (Wallet >= totalCost)
            {
                Wallet -= totalCost;
                Mood = Mood + (int)(totalCost * 0.5);
                if (Mood > 30) Mood = 30;
                message = $"Покупка совершена!\n" + $"Осталось денег: {Wallet} руб.\n" + $"Настроение: {Mood}";
            }
            else
            {
                double shortfall = totalCost - Wallet;
                Mood = Mood - (int)(shortfall);
                if (Mood < -30) Mood = -30;
                message = $"Недостаточно денег!\n" + $"Не хватило: {shortfall} руб.\n" + $"Настроение: {Mood}";
            }
            return message;
        }
        //Метод - посмотреть настроение
        public string GetMoodStatus()
        {
            string status;
            if (Mood > 15) status = "Бодрое";
            else if (Mood >= 5) status = "Нормальное";
            else if (Mood >= -10) status = "Плохое";
            else status = "Депрессивное";
            return $"Настроение: {status} ({Mood})";
        }
    }
}
