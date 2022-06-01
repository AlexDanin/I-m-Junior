using System;
using System.Globalization;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            DateTime birthday;

            var year = DateTime.Now.Year;
            var month = DateTime.Now.Month;
            var day = DateTime.Now.Day;

            Console.WriteLine("Введите свое имя: ");
            name = Console.ReadLine();
            Console.WriteLine("Введите свой день рождения (dd.mm.yyyy): ");
            birthday = DateTime.ParseExact(Console.ReadLine(), "dd.mm.yyyy", null, DateTimeStyles.None);

            Console.WriteLine($"Привет, {name}, тебе сейчас {year - birthday.Year - ((month > birthday.Month || month == birthday.Month && day >= birthday.Day) ? 1 : 0)} лет");
        }
    }
}
