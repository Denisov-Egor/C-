using System;

namespace MyApp 
{
    class Program
    {
        static void Main(string[] args)
        {
            int x; // Объявление 
            x = 123; // Инциализация
            int y = 321; // Объявление + инциализация
            int z = x + y;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine("Всего: " + z);

            int age = 21; // Только целое число 
            Console.WriteLine("Твой возраст равен: " + age);

            double height = 300.5; // Десятичное число
            Console.WriteLine("Мой рост: " + height + "см");

            bool alive = true; // Правда или лож
            Console.WriteLine("Ты жив? " +  alive);

            char symbol = '@'; // Только один симвл
            Console.WriteLine("Твой симвл: " + symbol);

            String name = "Егор"; // Строка
            Console.WriteLine("Мое имя: " + name);

            String userName = symbol + name; // Объеденение
            Console.WriteLine("Твое имя поьзователя: " +  userName);
        }
    }
}