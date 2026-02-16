//Напишите программу, которая вычисляет и выводит факториал числа N.

using System;

class Program
{
    static void Main()
    {
        int n, factorial;

        Console.Write("n = ");
        n = Convert.ToInt32(Console.ReadLine());

        Console.Write("factorial = ");
        factorial = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i ++)
            factorial *= i;

        Console.WriteLine(n + "! = " + factorial);
    }
}

