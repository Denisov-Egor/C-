// Сравните эффективность метода пузырька на различных типах данных (целые числа, строки) и размерах массивов.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите размерность массива: ");
        int NumSIZE = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[NumSIZE];

        Random rnd = new Random();

        for (int i = 0; i < NumSIZE; i++)
        {
            arr[i] = rnd.Next(1, 11);
            Console.WriteLine($"числовой массив {arr[i]}");
        }

        for (int i = 0; i < NumSIZE; i++)
        {
            for (int j = 0; j < NumSIZE - i - 1; j++)
            {
                if (arr[j] == arr[j + 1])
                {
                    int temp = arr[j];  
			        arr[j] = arr[j + 1]; 
			        arr[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Введите размерность массива: ");
        int StrSIZE = Convert.ToInt32(Console.ReadLine());

        string[] strings = new string[StrSIZE];

        for (int i = 0; i < StrSIZE; i++)
            strings[i] = Console.ReadLine();

        foreach (string str in strings)
            Console.WriteLine($"массив {str}");
    }
}
