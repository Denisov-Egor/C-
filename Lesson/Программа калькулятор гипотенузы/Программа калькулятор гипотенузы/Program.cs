using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
 

            Console.WriteLine("Введите чичло A: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите чичло B: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = Math.Sqrt(a * a + b * b);

            Console.WriteLine("Гипотенуза равна: " + c);
        }
    }
}
