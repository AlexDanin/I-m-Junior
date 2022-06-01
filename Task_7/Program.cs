using System;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int amountGold;
            int amountСrystals;
            int priceOfCrystals;

            Console.WriteLine("Сколько у вас золота?");
            amountGold = Convert.ToInt32(Console.ReadLine());

            priceOfCrystals = rand.Next(1, amountGold);

            Console.WriteLine($"Цена кристала: {priceOfCrystals}.\nСколько кристаллов вы хотите купить?");
            amountСrystals = Convert.ToInt32(Console.ReadLine());
            amountGold -= amountСrystals * priceOfCrystals;

            Console.WriteLine($"Ваши кристалы: {amountСrystals}.\nВаше золото: {amountGold}");
        }
    }
}
