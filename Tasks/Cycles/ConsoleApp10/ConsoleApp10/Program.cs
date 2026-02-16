// Напишите программу, которая выводит все целые числа в степени двойки от 1 до N.

using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        int n;

        Console.Write("n = ");
        n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; Math.Pow(2, i) <= n; i++)
        {
            Console.WriteLine(Math.Pow(2, i));
        }
    }
}