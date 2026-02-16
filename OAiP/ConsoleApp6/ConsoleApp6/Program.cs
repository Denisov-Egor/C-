using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите целое число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number <= 1)
        {
            Console.WriteLine("Это число не является натуральным.");
            return;
        }

        bool isPrime = true;

        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        if (isPrime)
        {
            Console.WriteLine("Это число является натуральным и простым.");
        }
        else
        {
            Console.WriteLine("Это число является натуральным, но не является простым.");
        }
    }
}
