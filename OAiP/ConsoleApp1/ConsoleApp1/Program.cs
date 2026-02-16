using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i+=3)
        {
            Console.Write(i + " ");
        }
    }
}