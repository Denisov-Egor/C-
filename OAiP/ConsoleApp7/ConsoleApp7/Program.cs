// Напишите программу на языке С#, которая подсчитывает число вхождений заданного элемента в одномерном массиве целых чисел.
using System;

class Program
{
    static void Main()
    {
        int count = 0;

        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 9 };

        int targetElement = 9;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == targetElement)
            {
                count++;
            }
        }
        Console.WriteLine($"Количество вхождений элемента {targetElement} в массиве: {count}");
    }
}