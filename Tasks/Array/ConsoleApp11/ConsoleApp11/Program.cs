// Напишите программу, которая создает двумерный массив из 3 строк и 4 столбцов,
// заполняет его случайными числами от 0 до 9, а затем выводит на экран.
using System;
using System.Drawing;

class Program
{
    static void Main()
    {
        int SIZE1, SIZE2;
        Console.Write("Введите кол-во эл: ");
        SIZE1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите кол-во эл: ");
        SIZE2 = Convert.ToInt32(Console.ReadLine());

        int[,] arr = new int[SIZE1, SIZE2];

        Random rnd = new Random();

        for (int i = 0; i < SIZE1; i++)
        {
            for (int j = 0; j < SIZE2; j++)
            {
                arr[i, j] = rnd.Next(1, 10);
                Console.Write(arr[i, j]);
            }
            Console.WriteLine();
        }
    }
}   