// Написать метод, который находит все палиндромы в строковом массиве и выводит их на экран.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество элементов в первом массиве: ");
        int SIZE = Convert.ToInt32(Console.ReadLine());

        string[] arr = new string[SIZE];

        for (int i = 0; i < SIZE; i++)
        {
            Console.Write($"Введите элемент {i + 1}: ");
            arr[i] = Console.ReadLine();


        }

        
    }
}