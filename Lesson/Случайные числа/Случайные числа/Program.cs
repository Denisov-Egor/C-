using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            //int num = random.Next(1, 7);
            double num = random.NextDouble();

            Console.WriteLine(num);
        }
    }
}