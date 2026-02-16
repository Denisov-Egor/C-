// Напишите программу, которая проверяет, содержит ли массив заданное число.

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
        Console.Write("Введите искомый эл: ");
        int num = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < arr.Length; i++)
        {
            if (num == arr[i])  
            {
                Console.WriteLine("Искомый эл найден");
            }else
             {
                Console.WriteLine("Искомый эл не найден");
             }
        }
    }
}