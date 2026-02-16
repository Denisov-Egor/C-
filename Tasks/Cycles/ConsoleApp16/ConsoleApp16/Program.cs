// Напишите программу, которая выводит все целые числа от 1 до N, которые делятся на A и B без остатка или являются степенью двойки.

using System;

class Program
{
    static void Main()
    {
        Console.Write("n = ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.Write("A = ");
        int A = Convert.ToInt32(Console.ReadLine());

        Console.Write("B = ");
        int B = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            if ((i % A == 0 && i % B == 0) || Math.Pow(i, 2) == (int)Math.Pow(i, 2))
            {
                Console.Write(i + " ");
            }
        }
    }
}

