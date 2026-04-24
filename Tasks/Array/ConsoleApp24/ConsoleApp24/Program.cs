using System;

class Program
{
    static void Main()
    {
        int[] arr = { 5, 2, 9, 1, 5, 6 };

        arr.Sort((x, y) => y.CompareTo(x));

        foreach (var Arr in arr)
        {
            Console.WriteLine(Arr);
        }
    }
}