using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {

            String name = "";

            while (name == "")
            {
                Console.Write("Введи свое имя: ");
                name = Console.ReadLine();
            }

            Console.WriteLine("Привет " + name);
        }
    }
}