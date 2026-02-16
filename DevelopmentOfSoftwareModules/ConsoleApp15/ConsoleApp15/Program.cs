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

            double numerator = 1;
            double denominator = 1;

            if (Math.Abs(x) > 1)
            {
                Console.WriteLine("Значение x должно быть в пределах [-1, 1]");
                return;
            }

            for (int i = 1; i <= n; i += 2)
            {
                for (int j = 0; j < i; j += 2)
                {
                    numerator *= j;   
                }
                numerator = Math.Pow(x, i);
                for (int k = 0; k < i; k += 2)
                {
                    denominator *= k;
                }

                sum += x + numerator / denominator;
            }

            Console.WriteLine($"Значение суммы ряда S равно {sum}");
        }
    }
}

