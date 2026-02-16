// Определить, является ли год високосным.

using System;

class Program
{
    static void Main()
    {
        Console.Write("year = ");
        int year = Convert.ToInt32(Console.ReadLine());

        bool IsLeapYear = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0); ;

        Console.WriteLine(IsLeapYear);
    }
}
