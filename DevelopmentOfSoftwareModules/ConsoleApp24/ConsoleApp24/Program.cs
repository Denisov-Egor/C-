// в одномерном массиве отсорортировать первые 5эл по возрастанию перемидальной сортировкой

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

        for(int i = 0; i < Math.Min(4, SIZE); i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < Math.Min(i + 5, SIZE); j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }

            int temp = arr[i];
            arr[i] = arr[minIndex];
            arr[minIndex] = temp;
        }

        Console.WriteLine("Отсортированный массив:");
        foreach (int item in arr)
        {
            Console.Write(item + " ");
        }
    }
}
