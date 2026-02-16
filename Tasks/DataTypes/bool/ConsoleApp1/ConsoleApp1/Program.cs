// Написать метод, который проверяет, является ли число положительным.

using System;

class Program
{
    static void Main()
    {
        Console.Write("n = ");
        int n = Convert.ToInt32(Console.ReadLine());

        bool isPositive = n > 0;

        Console.WriteLine(isPositive);
    }
}
