using System;

class Pogram
{
    static void Main()
    {
        int SIZE = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[SIZE];

        for (int i = 0; i < SIZE; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());

        }

        int sum = 0;
        for (int i = 0; i < SIZE; i++)
            if (arr[i] > 0) sum += arr[i];

        Console.WriteLine( + sum);
    }
}