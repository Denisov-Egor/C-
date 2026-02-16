// Напишите программу, которая выводит таблицу умножения для числа N.

using System;

class Program
{
    static void Main()
    {
        int n, x;

        Console.Write("n = ");
        n = Convert.ToInt32(Console.ReadLine());

        Console.Write("x = ");
        x = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= x; i++)
        {
            Console.WriteLine(n + " * " + i + " = " + n * i);
        }
    }
}

