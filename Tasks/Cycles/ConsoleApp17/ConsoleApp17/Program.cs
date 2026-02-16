// Напишите программу, которая принимает массив целых чисел и выводит каждый его элемент.

using System;
class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        foreach (var number in arr)
        {
            Console.WriteLine(number);
        }
    }
}
