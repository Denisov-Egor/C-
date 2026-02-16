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
    }
}