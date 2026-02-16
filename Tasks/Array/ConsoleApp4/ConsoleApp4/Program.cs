// Реализовать программу, которая объединяет два отсортированных массива в один отсортированный массив.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество элементов в первом массиве: ");
        int SIZE1 = Convert.ToInt32 (Console.ReadLine());

        int[] arr1 = new int[SIZE1];

        for (int i = 0; i < SIZE1; i++)
        {
            Console.Write($"Введите элемент {i + 1}: ");
            arr1[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Введите количество элементов во втором массиве: ");
        int SIZE2 = Convert.ToInt32(Console.ReadLine());

        int[] arr2 = new int[SIZE2];

        for (int j = 0; j < SIZE2; j++)
        {
            Console.Write($"Введите элемент {j + 1}: ");
            arr2[j] = Convert.ToInt32(Console.ReadLine());
        }

        Array.Sort(arr1);
        Array.Sort(arr2);

        int[] result = new int[arr1.Length + arr2.Length];

        for (int i = 0;i < arr1.Length;i++)
        {
            result[i] = arr1[i];
        }

        for (int i = 0; i < arr2.Length; i++)
        {
            result[arr1.Length + i] = arr2[i];
        }

        Array.Sort(result);

        Console.WriteLine("Объединенный отсортированный массив:");

        foreach (int num in result)
        {
            Console.Write(num + " ");
        }
    }
}