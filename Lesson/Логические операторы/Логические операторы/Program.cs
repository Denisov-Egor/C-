using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какая темпаратура на улице: (C) ");
            double temp = Convert.ToDouble(Console.ReadLine());

            if (temp >= 0 && temp < 25)
            {
                Console.WriteLine("На улице тепло");
            }
            else if (temp <= -50 || temp >= 50 )
            {
                Console.WriteLine("На улицу не выходить");
            }
        }
    }
}