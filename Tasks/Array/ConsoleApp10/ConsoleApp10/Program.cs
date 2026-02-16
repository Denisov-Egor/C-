// Напишите программу, которая сортирует массив в порядке возрастания и выводит его на экран.

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
            arr[i] = rnd.Next(1, 100);
            Console.WriteLine(arr[i]);
        }

        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
        Console.WriteLine("Упорядоченный массив по возрастанию:");
        for (int i = 0; i < arr.Length; i++)
            Console.Write(arr[i] + " ");
    }
}