// упорядочить одномерный массив по возрастанию удалив все нули

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество элементов в массиве: ");
        int SIZE = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[SIZE];

        for (int i = 0; i < SIZE; i++)
        {
            Console.Write($"Введите элемент {i + 1}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
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

        int newSize = 0;
        for (int i = 0; i < SIZE; i++)
        {
            if (arr[i] != 0)
                arr[newSize++] = arr[i];
        }

        Console.WriteLine("Упорядоченный массив без нулей:");
        for (int i = 0; i < newSize; i++)
            Console.Write(arr[i] + " ");
    }
}
