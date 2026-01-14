using System;

namespace Hello
{
    class Hello
        {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число a");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число b");
            int b = Convert.ToInt32(Console.ReadLine());

            int sum = a + b;
            Console.WriteLine(sum);

            int minus = a - b;
            Console.WriteLine(minus);

            int multipli = a * b;
            Console.WriteLine(multipli);

            int division = a / b;
            Console.WriteLine(division);
        }
    }
    
}
