// Напишите программу, которая выводит все целые числа от 1 до N включительно.

using System;

class Program
{
    static void Main()
    {
        int n;

        Console.Write("Введите n: ");

        n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(i);
            
        }
    }
}