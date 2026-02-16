using System;

class Program
{
    static void Main()
    {
        int average = 0;

        Console.Write("Введите число n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i <= n; i ++)
        {
            Console.Write("Введите числа x: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write(x);

            average += x;

        }
            Console.Write($"Среднее арифмитическое: {average}");

    }
}

