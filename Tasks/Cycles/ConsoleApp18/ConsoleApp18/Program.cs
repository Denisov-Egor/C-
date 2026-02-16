// Напишите программу, которая принимает массив целых чисел и вычисляет их сумму.

using System;
class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        int sum = 0;

        foreach (var number in arr)
        {
            sum += number;
        }
        Console.WriteLine(sum);
    }
}
