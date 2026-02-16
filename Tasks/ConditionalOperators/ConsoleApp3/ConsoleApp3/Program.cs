// Напишите код, который принимает от пользователя ввод и проверяет, является ли он одним из следующих слов: "apple", "banana", "orange".
// Если да, то выводит "This is a fruit!",
// если нет - "This is not a fruit!".

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите ващ любимый фрукт (apple, banana, orange)");
        string fruit = Console.ReadLine();

        switch (fruit)
        {
            case "apple":
                Console.WriteLine("Это фрукт!");
                break;
            case "banana":
                Console.WriteLine("Это фрукт!");
                break;
            case "orange":
                Console.WriteLine("Это фрукт!");
                break;
            default:
                Console.WriteLine("Это не фрукт!");
                break;
        }
    }
}