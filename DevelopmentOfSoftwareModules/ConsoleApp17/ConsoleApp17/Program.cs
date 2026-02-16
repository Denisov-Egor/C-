// найти сумму пол эл массива

using System;

class Program
{
    static void Main()
    {
        int max = 0;


        Console.Write("Введите количество элементов в массиве: ");
        int size = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[size];

        int sum = arr[0];

        for (int i = 0; i < size; i++)
        {
            Console.Write($"Введите элемент {i + 1}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());

            if (arr[i] % 2 == 0)
            {
                sum += arr[i];
            } 
        }

        Console.WriteLine($"Максимальный эл в массиве: {max}");
    }
}

