using System; 

namespace Hello
{
    class Hello
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число a");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите число b");
            double b = Convert.ToDouble(Console.ReadLine());

            if (a == 0 || b == 0)
            {
                Console.WriteLine("Деление на 0 невозможно");
            } else {
                double division = a / b;
                Console.WriteLine(division);
            }

                double sum = a + b;
            Console.WriteLine(sum);

            double minus = a - b;
            Console.WriteLine(minus);

            double multipli = a * b;
            Console.WriteLine(multipli);

            
        }
    }
}