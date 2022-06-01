using System;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            const int TimeOfAppointment = 10;
            const int MinuntsInHour = 60;
            int peopleAmount;

            int hoursOfWaiting;
            int minutesOfWaiting;

            Console.WriteLine("Введите кол-во старушек в очереди:");
            peopleAmount = Convert.ToInt32(Console.ReadLine());
            
            int allTimeOfWaiting = (peopleAmount * timeOfAppointment);

            hoursOfWaiting = allTimeOfWaiting / minuntsInHour;
            minutesOfWaiting = allTimeOfWaiting % minuntsInHour;

            Console.WriteLine($"Вы должны отстоять в очереди {hoursOfWaiting} часа и {minutesOfWaiting} минут.");
        }
    }
}
