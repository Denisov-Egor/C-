using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        int i = 0;

        while (i <= n)
        {
            sum += i;
            i+=2;
        }

        Console.WriteLine("Сумма четных чисел от 0 до n = sum");
        Console.WriteLine(sum);
    }
}