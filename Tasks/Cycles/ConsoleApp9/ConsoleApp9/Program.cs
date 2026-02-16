// Напишите программу, которая выводит все целые числа от 1 до N, которые делятся на M без остатка.

using System;

class Program
{
    static void Main()
    {
        int n, m;

        Console.Write("n = ");
        n = Convert.ToInt32(Console.ReadLine());

        Console.Write("m = ");
        m = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            if (i % m == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}   