// Напишите программу, которая вычисляет сумму первых N натуральных чисел.

using System;

class Program
{
    static void Main()
    {
        int n;
        int sum = 0;

        Console.Write("n = ");
        n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            sum += i;
        }
        Console.WriteLine(sum);
    }
}