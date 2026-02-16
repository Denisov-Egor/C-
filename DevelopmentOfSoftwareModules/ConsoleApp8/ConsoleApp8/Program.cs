using System;

namespace Hello
{
    class Hello
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите количество членов ряда (n):");   
            int n = Convert.ToInt32(Console.ReadLine());

            double S = 0;

            for (int i = 1; i <= n; i++)
            {
                double factorial = 1;
                for (int j = 1; j <= 2 * i; j++)
                    factorial *= j;
                double term = (x * x / 2) / factorial;
                S += term;
            }

            Console.WriteLine($"Значение суммы ряда S равно {S}");

        }
    }
}
