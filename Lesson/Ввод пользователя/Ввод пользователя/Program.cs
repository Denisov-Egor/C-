using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как тебя зовут? ");
            String name = Console.ReadLine();

            Console.WriteLine("Сколько тебе лет? ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Привет " + name);
            Console.WriteLine("Твой возраст " + age + "лет");
        }
    }
}