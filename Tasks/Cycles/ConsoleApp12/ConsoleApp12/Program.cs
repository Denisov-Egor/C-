// Напишите программу, которая выводит все простые числа в диапазоне от 2 до N.

using System;

class Program
{
    static void Main()
    {
        Console.Write("n = ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 2; i <= n; i++)
        {
            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}