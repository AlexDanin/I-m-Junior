using System;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int allPictures = 52;
            int rowPictures = 3;

            int rowCount = allPictures / rowPictures;
            int remainder = allPictures % rowPictures;

            Console.WriteLine($"полностью заполненных рядов можно вывести {rowCount}, и осталось картинок сверх меры {remainder}");
        }
    }
}
