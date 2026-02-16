using System;

namespace Program
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите x:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите количество членов ряда (n):");
            int n = Convert.ToInt32(Console.ReadLine());

            double sum = 0;
            double factorial = 0;

            for (int i = 1; i <= n; i ++)
            {
                double term = Math.Pow(-1, i) * Math.Pow(x, 2 * i);
                for (int j = 2; j <= i / 2; j++)
                {
                    factorial *= j;
                }
                sum += term / factorial;
            }


            Console.WriteLine($"Значение суммы ряда S равно {sum}");
        }
    }
}