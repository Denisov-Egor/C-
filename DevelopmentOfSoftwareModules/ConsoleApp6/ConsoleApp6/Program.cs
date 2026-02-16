using System;

namespace Hello
{
    class Hello
    {
        static void Main(string[] args)
        {
            double sum = 0;

            Console.Write("Введите число n: ");
            double n = Convert.ToInt32(Console.ReadLine());

            for (double i = 1; i <= n; i++)
            {
                double fact = 1;
                for (double j = 1; j <= i; j++)
                {
                    fact *= j;
                }
                sum += i / fact;
            }

            Console.WriteLine(sum);
        }
    }
}