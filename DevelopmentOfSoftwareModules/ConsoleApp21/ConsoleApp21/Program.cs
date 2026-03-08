// найти сумму модулей отрицательных эл двумерного массива 

using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

class  Program
{
    static void Main()
    {
        Console.Write("Введите количество строк: ");
        int height = int.Parse(Console.ReadLine());

        Console.Write("Введите количество столбцов: ");
        int widht = int.Parse(Console.ReadLine());

        int[,] arr = new int[height, widht];

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < widht; j++)
            {
                Console.Write($"Введите элемент [{i + 1}, {j + 1}]: ");
                arr[i, j] = int.Parse(Console.ReadLine());
            }
        }
        int result = Sum(arr);

        Console.WriteLine("Сумма модулей отрицательных элементов: " + result);
    }

    static int Sum(int[,]arr)
    {
        int sum = 0;

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (arr[i, j] < 0)
                    sum += Math.Abs(arr[i, j]);
            }
        }

        return sum;
    }
}
