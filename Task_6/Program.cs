using System;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int allPictures = 52;
            int picturesInRow = 3;

            int filledRowCount = allPictures / picturesInRow;
            int remainderOfPictures = allPictures % picturesInRow;

            Console.WriteLine($"полностью заполненных рядов можно вывести {filledRowCount}, и осталось картинок сверх меры {remainderOfPictures}");
        }
    }
}
