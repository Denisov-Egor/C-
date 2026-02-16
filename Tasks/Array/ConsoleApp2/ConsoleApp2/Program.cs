// Создать массив строк и вывести все строки, содержащие определенную подстроку.

using Microsoft.VisualBasic;
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество элементов в массиве: ");
        int SIZE = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите слово которое нужно найти: ");
        string searchSubstring = Convert.ToString(Console.ReadLine());

        string[] arr = new string[SIZE];

        for (int i = 0; i < SIZE; i++)
        {
            Console.Write("Введите строку №" + (i + 1) + ": ");
            arr[i] = Convert.ToString(Console.ReadLine());

            if (searchSubstring == arr[i])
            {
                string str = arr[i];
                Console.WriteLine(str);
            }
        }

    }
}
