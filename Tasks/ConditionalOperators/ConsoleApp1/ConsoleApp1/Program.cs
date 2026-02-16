// Пользователь вводит число от 1 до 7. Программа должна вывести на экран название дня недели (например, "Понедельник", "Вторник" и т.д.).

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число от 1 до 7: ");
        int dayNumber = Convert.ToInt32(Console.ReadLine());

        switch (dayNumber)
        {
            case 1:
                Console.WriteLine("Понедельник");
                break;
            case 2:
                Console.WriteLine("Вторик");
                break;
            case 3:
                Console.WriteLine("Среда");
                break;
            case 4:
                Console.WriteLine("Четверг");
                break;
            case 5:
                Console.WriteLine("Пятница");
                break;
            case 6:
                Console.WriteLine("Суббота");
                break;
            case 7:
                Console.WriteLine("Воскрессение");
                break;
        }
    }
}
