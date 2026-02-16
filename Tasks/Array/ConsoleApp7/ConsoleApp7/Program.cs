// Напишите программу, которая принимает массив чисел от пользователя и выводит максимальное значение.

using System;

class Program
{
    static void Main()
    {

        Console.Write("Введите кол-во эл: ");
        int SIZE = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[SIZE];

        for (int i = 0; i < SIZE; i++)
        {
            Console.Write($"Введите элемент {i + 1}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        int max = arr[0];

        foreach (int num in arr)
        {
            if (num > max)
            {
                max = num;
            }
        }
        Console.WriteLine(max);
    }
}