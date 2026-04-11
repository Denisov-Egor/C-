using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            {
                Console.WriteLine("Введите 1 число");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Выберите опирацию");
                char operation= Convert.ToChar(Console.ReadLine());

                Console.WriteLine("Введите 2 число");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = 0;
                bool isValidOperation = true;

                switch (operation)
                {
                    case '+':
                        result = Add(num1, num2);
                        break;
                    case '-':
                        result = Subtract(num1, num2);
                        break;
                    case '*':
                        result = Multiply(num1, num2);
                        break ;
                    case '/':
                        if (num2 == 0)
                        {
                            Console.WriteLine("Ошибка: Деление на ноль.");
                            isValidOperation = false;
                        }
                        else
                        {
                            result = Divide(num1, num2);
                        }
                        break;
                    default:
                        Console.WriteLine("Ошибка: Недопустимая операция.");
                        isValidOperation = false;
                        break;
                }
                if (isValidOperation)
                {
                    Console.WriteLine($"Результат: {result}");
                }

                Console.WriteLine("Хотите продолжить? (y/n):");
                string continueChoice = Console.ReadLine().ToLower();
                if (continueChoice != "y")
                {
                    break;
                }
            }
        }
    }

    static double Add(double a, double b)
    {
        return a + b;
    }

    static double Subtract(double a, double b)
    {
        return a - b;
    }

    static double Multiply(double a, double b)
    {
        return a * b;
    }

    static double Divide(double a, double b)
    {
        return a / b;
    }
}