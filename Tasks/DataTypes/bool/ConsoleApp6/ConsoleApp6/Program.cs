// Определить, является ли число чётным.

using System;

class Program
{
    static void Main()
    {
        Console.Write("n = ");
        int n = Convert.ToInt32(Console.ReadLine());

        bool number = n % 2 == 0;

        Console.WriteLine(number);
    }
}
