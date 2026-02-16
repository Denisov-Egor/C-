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

            int i = 1;
            while (i <= n)
            {
                double factorial = 1;

                int j = 1;
                while(j <= 2)
                {
                    factorial *= j;
                    double term = (x * x / 2) / factorial;
                    S += term;
                    j++;
                }
                i++;
            }
            Console.WriteLine($"Значение суммы ряда S равно {S}");

        }
    }
}
