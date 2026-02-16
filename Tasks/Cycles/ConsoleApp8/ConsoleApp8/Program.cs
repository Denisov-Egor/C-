// Напишите программу, которая проверяет наличие элемента в одномерном целочисленном массиве.

using System;
using System.Drawing;

class Program
{
    static void Main()
    {
        int SIZE;
        int target;

        Console.Write("Введите размер массива: ");
        SIZE = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите число которое нужно найти: ");
        target = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[SIZE];

        for (int i = 0; i < SIZE; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());

            if (i < arr.Length)
            {
                if(arr[i] == target)
                {
                    Console.WriteLine($"эл найден в массиве: {target}");
                }else
                {
                    Console.WriteLine("эл не найден в массиве.");
                }
            }
        }
    }
}