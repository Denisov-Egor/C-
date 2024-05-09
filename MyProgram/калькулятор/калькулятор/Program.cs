namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {

                double num1 = 0;
                double num2 = 0;
                double resulat = 0;

                Console.Write("Введите 1 число: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите 2 число: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ввеберите опцию");
                Console.WriteLine("\t+");
                Console.WriteLine("\t-");
                Console.WriteLine("\t*");
                Console.WriteLine("\t/");
                Console.Write("Введите опцию: ");

                switch (Console.ReadLine())
                {
                    case "+":
                        resulat = num1 + num2;
                        Console.WriteLine(resulat);
                        break;

                    case "-":
                        resulat = num1 - num2;
                        Console.WriteLine(resulat);
                        break;

                    case "*":
                        resulat = num1 * num2;
                        Console.WriteLine(resulat);
                        break;

                    case "/":
                        resulat = num1 / num2;
                        Console.WriteLine(resulat);
                        break;

                    default:
                        Console.WriteLine("Токого нет!");
                        break;
                }
                Console.WriteLine("Ты хочешь продолжить игру? (ДА НЕТ)");
            } while (Console.ReadLine().ToUpper() == "ДА");

            Console.WriteLine("Пока!");
        }
    }
}