using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Bob";
            string surname = "White";

            Console.WriteLine(name + " " + surname);

            (name, surname) = (surname, name);

            Console.WriteLine(name + " " + surname);
        }
    }
}
