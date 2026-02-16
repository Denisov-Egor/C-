using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите количество членов ряда (n):");
            int n = Convert.ToInt32(Console.ReadLine());

            double sum = 0;

            for (int i = 1; i <= n; i += 2)
                sum += Math.Pow(-1, i) * (3 * Math.Pow(x, 3 * i)) / (2 * i + 1) - Math.Pow(-1, i) / ((2 * i + 1) * Math.Pow(x, 2 * i + 1));

            double res = Math.PI / 2 - sum;

            Console.WriteLine($"Значение суммы ряда S равно {res}");
        }
    }
}