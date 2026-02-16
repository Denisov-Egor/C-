// Написать программу, которая заполняет массив случайными числами и находит максимальное значение.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество элементов в массиве: ");
        int SIZE = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[SIZE];
        Random rand = new Random();

        int max = arr[0];

        for (int i = 0; i < SIZE; i++)
        {
            arr[i] = rand.Next(1, 10);
            Console.WriteLine(arr[i]);

            for (int j = 1; j < arr.Length; j++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
        }
        Console.WriteLine("Максимальное значение: " + max);
    }
}
