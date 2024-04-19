using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 3;
            double y = -5;
            double z = 3.14;
            double q = 3.99;

            double a = Math.Pow(x, 2); // Степень
            double b = Math.Sqrt(x); // Корень
            double c = Math.Abs(y); // Положительно число
            double d = Math.Round(z); // Округление
            double e = Math.Ceiling(z); // Округление до большего
            double f = Math.Floor(q); // Округление до наименьшего
            double g = Math.Max(x, y); // Вывод наибольшего 
            double h = Math.Min(x, y); // Вывод наименьшего 

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(z);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(h);
        }
    }
}