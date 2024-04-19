using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Сколько строк?: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Сколько столбцов?: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            Console.Write("Укажите символ: ");
            String symbol = Console.ReadLine();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }
    }
}