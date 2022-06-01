using System;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            const int timeOfAppointment = 10;
            const int minInHour = 60;
            int peopleAmount;

            int hours;
            int minutes;

            Console.WriteLine("Введите кол-во старушек в очереди:");
            peopleAmount = Convert.ToInt32(Console.ReadLine());

            hours = (peopleAmount * timeOfAppointment) / minInHour;
            minutes = (peopleAmount * timeOfAppointment) % minInHour;

            Console.WriteLine($"Вы должны отстоять в очереди {hours} часа и {minutes} минут.");
        }
    }
}
