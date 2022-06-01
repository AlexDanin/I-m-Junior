using System;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int amountGold;
            int amountСrystals;
            int priceOfCrystal;

            Console.WriteLine("Сколько у вас золота?");
            amountGold = Convert.ToInt32(Console.ReadLine());

            priceOfCrystal = random.Next(1, amountGold);

            Console.WriteLine($"Цена кристала: {priceOfCrystal}.\nСколько кристаллов вы хотите купить?");
            amountСrystals = Convert.ToInt32(Console.ReadLine());
            
            amountGold -= amountСrystals * priceOfCrystal;

            Console.WriteLine($"Ваши кристалы: {amountСrystals}.\nВаше золото: {amountGold}");
        }
    }
}
