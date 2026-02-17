// Реализуйте функцию, которая проверяет, отсортирован ли массив с помощью метода пузырька.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите размерность массива: ");
        int SIZE = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[SIZE];

        Random rnd = new Random();

        for (int i = 0; i < SIZE; i++)
        {
            arr[i] = rnd.Next(1, 11);
            Console.WriteLine($"Не отсартированный массив: {arr[i]}");
        }

        for (int i = 0; i < SIZE; i++)
        {
            for (int j = 0; j < SIZE - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }

        for (int i = 0; i < SIZE; i++)
            Console.WriteLine($"Отсартированный массив: {arr[i]}");

        static bool isSorted (int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] > arr[i])
                {
                    return false;
                }
            }
            return true;
        }

        bool result; 
        result = isSorted(arr);

        Console.WriteLine(isSorted(arr));
    }
}