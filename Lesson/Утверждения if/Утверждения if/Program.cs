using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свой возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age > 100)
            {
                Console.WriteLine("Ты слишком старый!");
            }
            else if (age >= 18)
            {
                Console.WriteLine("Ты можешь офрмить карту!");
            }
            else if (age < 0)
            {
                Console.WriteLine("Ты еще не родился!");
            }
            else
            {
                Console.WriteLine("Сюда можно только с 18 лет!");
            }

            Console.WriteLine("Введите свой имя: ");
            String  name = Console.ReadLine();

            if (name == "")
            {
                Console.WriteLine("Ты не ввел свое имя!");
            }
            else
            {
                Console.WriteLine("Привет " + name);
            }
        }
    }
}