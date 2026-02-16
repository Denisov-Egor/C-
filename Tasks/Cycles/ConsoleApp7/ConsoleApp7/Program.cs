// Напишите программу, которая выводит все целые числа от N до 1 включительно.

using System;

class Program
{
    static void Main()
    {
        int n = Convert.ToInt32 (Console.ReadLine());

        for (int i = n; i >= 1; i--)
        {
            Console.WriteLine(i);
        }
    }
}