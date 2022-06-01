using System;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int allPictures = 52;
            int rowPictures = 3;

            Console.WriteLine($"полностью заполненных рядов можно вывести {allPictures / rowPictures}, и осталось картинок сверх меры {allPictures % rowPictures}");
        }
    }
}
