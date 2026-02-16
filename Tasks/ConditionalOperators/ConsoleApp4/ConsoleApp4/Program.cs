// Создайте программу для определения времени года.
// Пользователь вводит номер месяца (1-12),
// а программа должна вывести соответствующий сезон (winter, spring, summer, autumn).

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите номер месяца (1-12): ");
        int monthNumber = Convert.ToInt32(Console.ReadLine());

        switch (monthNumber)
        {
           case 1:
                Console.WriteLine("January");
                break;
            case 2:
                Console.WriteLine("February");
                break;
            case 3:
                Console.WriteLine("March");
                break;
            case 4:
                Console.WriteLine("April");
                break;
            case 5:
                Console.WriteLine("May");
                break;
            case 6:
                Console.WriteLine("June");
                break;
            case 7:
                Console.WriteLine("July");
                break;
            case 8:
                Console.WriteLine("August");
                break;
            case 9:
                Console.WriteLine("September");
                break;
            case 10:
                Console.WriteLine("October");
                break;
            case 11:
                Console.WriteLine("November");
                break;
            case 12:
                Console.WriteLine("December");
                break;
            default:
                Console.WriteLine("Неверный ввод. Пожалуйста, введите число от 1 до 12.");
                break;
        }
    }
}
