// Напишите программу, которая принимает массив целых чисел и подсчитывает количество положительных чисел.

using System;
class Program
{
    static void Main()
    {
        int[] arr = { -5, 10, -3, 20, 0, -7  };
        int countPositive = 0;

        foreach (var number in arr)
        {
            if (number >= 0)
            {
                countPositive++;
            }
        }
        Console.WriteLine(countPositive);
    }
}
