// Напишите программу, которая находит сумму всех положительных чисел в массиве.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите кол-во эл: ");
        int SIZE = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[SIZE];

        Random rnd = new Random();

        for (int i = 0; i < SIZE; i++)
        {
            arr[i] = rnd.Next(-11, 11);
            Console.WriteLine(arr[i]);
        }

        int positiveSum = 0;
        foreach (int num in arr)
        {
            if (num >= 0)
            {
                positiveSum += num;
            }
        }
        Console.WriteLine(positiveSum);
    }
}