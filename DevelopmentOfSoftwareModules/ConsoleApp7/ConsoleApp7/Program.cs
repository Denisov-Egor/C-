using System;

namespace Hello
{
    class Hello
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double numerator=1;
            double denominator=1;

            Console.Write("Введите кол-во члкна n: ");
            double n = Convert.ToInt32(Console.ReadLine());

            for (double i = 1; i <= n; i++)
            {
                
                for (double j = 1; j <= i; j+=2)
                    numerator *= j;
                sum += i / numerator;
                for (double j = 2; j <= i; j += 2)
                    denominator *= j;
                sum += i / denominator;
            }

            Console.WriteLine(sum);
        }
    }
}