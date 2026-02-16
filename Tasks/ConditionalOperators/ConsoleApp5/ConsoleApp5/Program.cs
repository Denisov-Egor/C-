// Напишите код, который проверяет, является ли введенное число однозначным, двузначным или трехзначным.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        int n = Convert.ToInt32(Console.ReadLine());

        switch (n.ToString().Length)
        {
            case 1:
                Console.WriteLine("Однозначное число");
                break;
            case 2:
                Console.WriteLine("Двузначное число");
                break;
            case 3:
                Console.WriteLine("Трёхзначное число");
                break;
            default:
                Console.WriteLine("Число не входит в диапазон от 1 до 999.");
                break;
        }
    }
}
