// Напишите программу на языке С#, которая находит наибольший и наименьший элемент в массиве.
using System;

class Program
{
    static void Main()
    {
        int[] array = {0, 1, 2, 3, 4, 5, 3, 6, 7, 8, 9, 10 };

        int min = 0, max = 0;

        
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }

            if (array[i] < min)
            {
                min = array[i];
            }
        }

       Console.WriteLine($"Максимальный эл в массиве: {max}");
       Console.WriteLine($"Минимальный эл в массиве: {min}");
    }
}
