using System;

namespace Hello
{
    class Hello
    {
        static void Main(string[] args)
        {
            int sum = 0;

            Console.Write("Введите число n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= n; i++)
                sum = i + n;

            Console.WriteLine(sum);
        }
    }
}