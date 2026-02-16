// Напишите программу на языке С#, которая подсчитывает количество элементов в массиве, кратных 3.

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
            if (arr[i] % 3 ==0)
            {
                countOutsideRange++;
            }
        }

        Console.WriteLine(countOutsideRange);
    }
}
