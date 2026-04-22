using System;

class Program
{
    static void Main()
    {
        int n = Convert.ToInt32 (Console.ReadLine());

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        int min = 0;
        int max = 0;

        for (int i = 0; i < n; i++)
        {
            if (arr[i] < arr[min])
            {
                min = arr[i];
                
            }

            if (arr[i] > arr[max])
            {
                max = arr[i];
               
            }
        }

        Console.WriteLine(min);
        Console.WriteLine(max);
    }
}