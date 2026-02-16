// Напишите программу, которая создает массив из случайных чисел от 1 до 10 и выводит его на экран в обратном порядке.

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

        Array.Reverse(arr);
        Console.WriteLine("После изменения порядка элементов: ");

        foreach (int num in arr)
        {
            Console.WriteLine(num);
        }
    }
}