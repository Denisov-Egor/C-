using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Введите x:");
            double x = Convert.ToDouble(Console.ReadLine());

            if (Math.Abs(x) > 1)
            {
                Console.WriteLine("Значение x должно быть в пределах [-1, 1]");
                return; 
            }

            Console.WriteLine("Введите количество членов ряда (n):");
            int n = Convert.ToInt32(Console.ReadLine());

            double sum = 0;

            for (int i = 1; i <= n; i+=2)
                    sum += (Math.Pow(-1, i) * Math.Pow(x, i) )/ i;

            Console.WriteLine($"Значение суммы ряда S равно {sum}");
        }
    }
}
