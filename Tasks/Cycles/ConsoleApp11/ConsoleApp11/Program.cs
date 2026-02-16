// Напишите программу, которая выводит все делители числа N.

using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.Write("n = ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                Console.Write(i + " ");
            }
        }
    }
}