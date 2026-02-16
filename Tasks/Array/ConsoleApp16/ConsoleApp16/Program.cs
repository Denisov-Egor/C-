// Напишите программу, которая находит среднее значение всех элементов массива.

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
            arr[i] = rnd.Next(1, 11);
            Console.WriteLine(arr[i]);
        }

        double sum = 0;
        foreach (int num in arr)
        {
            sum += num;
        }
        Console.WriteLine($"Сумма всех чисел {sum}");

        double average = 0;

        average = sum / arr.Length;

        Console.WriteLine(average);
    }
}