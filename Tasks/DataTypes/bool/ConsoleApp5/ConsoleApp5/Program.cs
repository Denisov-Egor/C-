// Определить, принадлежит ли точка (x, y) в первой четверти координатной плоскости.

using System;

class Program
{
    static void Main()
    {
        Console.Write("x = ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.Write("y = ");
        int y = Convert.ToInt32(Console.ReadLine());

        bool IsInFirstQuadrant = x > 0 && y > 0;

        Console.WriteLine(IsInFirstQuadrant);
    }
}
