using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите первое число: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int b = Convert.ToInt32(Console.ReadLine());

        int gcd = FindGCD(a, b);

        int lcm = a * b / gcd;

        Console.WriteLine($"Наибольший общий делитель ({a} и {b}): {gcd}");
        Console.WriteLine($"Наибольшее общее кратное ({a} и {b}): {lcm}");
    }

    static int FindGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return Math.Abs(a);
    }
}
