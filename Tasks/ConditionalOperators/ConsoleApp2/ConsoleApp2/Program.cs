// Создайте программу, которая запрашивает у пользователя его любимый фрукт (apple, banana, orange).
// В зависимости от выбора выводите сообщение с рекомендацией кушать этот фрукт.

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
                Console.WriteLine("Кушайте яблоко!");
                break;
            case "banana":
                Console.WriteLine("Кушайте банана!");
                break;
            case "orange":
                Console.WriteLine("Кушайте опельсинчик!");
                break;
        }
    }
}