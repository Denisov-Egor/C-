//Напишите программу, которая находит и выводит максимальное значение в целочисленном массиве.

using System;

class Program
{
    static void Main()
    {
        int n;
        int max = 0;

        Console.Write("Введите количество элементов в массиве: ");
        n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());

            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        Console.WriteLine(max);
    }
}

