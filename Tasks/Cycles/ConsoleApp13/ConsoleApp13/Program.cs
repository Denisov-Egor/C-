// Напишите программу, которая выводит первые N треугольных чисел.
using System;

class Program
{
    static void Main()
    {
        Console.Write("n = ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine((i * (i + 1)) / 2 + " ");
        }
    }
}