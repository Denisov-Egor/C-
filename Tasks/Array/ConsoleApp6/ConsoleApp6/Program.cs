// Напишите программу, которая принимает массив чисел от пользователя и выводит сумму элементов.

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

        int sum = 0;

        foreach (int i in arr)
        {
            sum += i;
        }

        Console.WriteLine(sum);
    }
}