// в одномерном массиве отсорортировать первые 5эл по возрастанию

using System;

public class Program
{
    static void Main()
    {
        Console.Write("Введите количество элементов в массиве: ");
        int SIZE = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[SIZE];

        for (int i = 0; i < SIZE; i++)
        {
            Console.Write($"Введите элемент {i + 1}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < Math.Min(5, SIZE); i++)
        {
            for (int j = 0; j < Math.Min(4 - i, SIZE - 1); j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
        Console.WriteLine("Отсортированный массив:");
        foreach (int item in arr)
        {
            Console.Write(item + " ");
        }
    }
}
