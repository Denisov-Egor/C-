using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество элементов в массиве: ");
        int size = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[size];

        for (int i = 0; i < size; i++)
        {
            Console.Write($"Введите элемент {i + 1}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Введенный массив:");
        for (int i = 0; i < size; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}

