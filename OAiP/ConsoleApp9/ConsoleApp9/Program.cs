// Напишите программу на языке С#, которая в массиве считает количество элементов, значения которых находятся вне диапазона от -100 до +100.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество элементов в массиве: ");
        int size = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[size];

        for (int i = 0; i < size; i++)
        {
            Console.Write($"Введите элемент {i + 1}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        int countOutsideRange = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < -100 || arr[i] > 100)
            {
                countOutsideRange++;
            }
        }

        Console.WriteLine(countOutsideRange);
    }
}
