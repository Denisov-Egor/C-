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

        int sum = 0;

        for (int i = 0; i < SIZE; i++)
        {
            sum += arr[i] * arr[i];
        }

        Console.WriteLine("Сумма квадратов элементов: " + sum);
    }
}
