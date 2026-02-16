// Напишите программу, которая принимает массив целых чисел и находит максимальный элемент.

using System;
class Program
{
    static void Main()
    {
        int[] arr = { 5, 10, 15, 20, 25 };
        int max = arr[0];

        foreach (var number in arr)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine(max);
    }
}
