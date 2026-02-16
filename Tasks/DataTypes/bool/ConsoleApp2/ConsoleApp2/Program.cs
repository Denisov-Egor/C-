// Сравнить две строки и вернуть true, если они равны, в противном случае - false.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку:");
        string str1 = Console.ReadLine();

        Console.WriteLine("Введите строку:");
        string str2 = Console.ReadLine();

        bool isPositive = str1 == str2;

        Console.WriteLine(isPositive);
    }
}
