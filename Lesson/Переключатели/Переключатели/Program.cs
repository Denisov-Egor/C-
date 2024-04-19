using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какой сегоня день?");
            String day = Console.ReadLine();

            switch (day)
            {
                case "Понедельник":
                    Console.WriteLine("Это понедельник");
                    break;

                case "Вторник":
                    Console.WriteLine("Это Вторник");
                    break;

                case "Среда":
                    Console.WriteLine("Это Среда");
                    break;

                case "Четвер":
                    Console.WriteLine("Это Четвер");
                    break;

                case "Пятница":
                    Console.WriteLine("Это Пятница");
                    break;

                case "Суббота":
                    Console.WriteLine("Это Суббота");
                    break;

                case "Воскресение":
                    Console.WriteLine("Это Воскресение");
                    break;

                default:
                    Console.WriteLine("Такого варианта нет");
                        break;
            }
        }
    }
}