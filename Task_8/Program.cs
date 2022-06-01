using System;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            const int timeOfAppointment = 10;
            int peopleAmount;

            Console.WriteLine("Введите кол-во старушек в очереди:");
            peopleAmount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Вы должны отстоять в очереди {(peopleAmount * timeOfAppointment) / 60} часа и {(peopleAmount * timeOfAppointment) % 60} минут.");
        }
    }
}
