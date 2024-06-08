using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] cars = { "BMW", "Mustang", "Corvett"};

            cars[0] = "Tesla"; // Замена в массиве

            /*Console.WriteLine(cars[0]); // Выводит 1 элемент
            Console.WriteLine(cars[1]); // Выводит 2 элемент
            Console.WriteLine(cars[2]); // Выводит 3 элемент*/

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]); // Нормальный вывод 
            }
        }
    }
}