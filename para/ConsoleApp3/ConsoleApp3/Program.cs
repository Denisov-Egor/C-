// найти сумму четныч чисел от 0 до n

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int sum = 0;

        for (int i = 0; i <= n; i+=2)
         sum += i;

        Console.WriteLine("Сумма четных чисел от 0 до n = sum");
        Console.WriteLine(sum);
    }
}

