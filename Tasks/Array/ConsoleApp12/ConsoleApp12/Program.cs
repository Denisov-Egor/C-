// Напишите программу, которая создает массив из случайных чисел от 1 до 10 и выводит его на экран в обратном порядке.
using System;
using System.Drawing;

class Program
{
    static void Main()
    {
        int SIZE1, SIZE2;
        Console.Write("Введите кол-во эл: ");
        SIZE1 = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[SIZE1];

        Random rnd = new Random();

        for (int i = 0; i < SIZE1; i++)
        {
            arr[i] = rnd.Next(1, 11);
            Console.WriteLine(arr[i] + " ");
        }

        Console.WriteLine("Массив в обратном порядке:");
        for (int i = SIZE1 - 1; i >= 0; i--)
        {
            Console.Write(arr[i] + " ");
        }
    }
}