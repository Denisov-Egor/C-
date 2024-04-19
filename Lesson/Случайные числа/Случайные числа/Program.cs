using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int nam = random.Next(1, 7);

            Console.WriteLine(nam);
        }
    }
}