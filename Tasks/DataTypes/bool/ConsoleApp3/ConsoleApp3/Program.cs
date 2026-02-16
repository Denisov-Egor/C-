// Проверить, находится ли число в диапазоне от 0 до 100 (включительно).

using System;

class Program
{
    static void Main()
    {
        Console.Write("n = ");
        int n = Convert.ToInt32 (Console.ReadLine());

        bool IsInRange = n >= 0 && n <= 100;

        Console.WriteLine(IsInRange);
    }
}
