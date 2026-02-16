// Напишите программу, которая выводит все простые числа в диапазоне от 1 до N.

using System;

class Program
{
    static void Main()
    {
        int n;

        Console.Write("n = ");
        n = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 0; i <= n; i+= 2)
                Console.WriteLine(i);
    }
}

