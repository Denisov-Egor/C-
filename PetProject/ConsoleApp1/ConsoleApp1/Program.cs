using System;

class Calculato
{
    static void Main()
    {
        double a, b, result;

        Console.WriteLine("Выберте действия в меню \r\n" +
            "1) Сложить (A + B)\r\n" +
            "2) Вычесть (A - B)\r\n" +
            "3) Умножить (A * B)\r\n" +
            "4) Делить (A / B)\r\n" +
            "5) Возвести в степень (A ^ B)\r\n" +
            "6) Остаток от деления (A % B)\r\n" +
            "7) Показать историю\r\n" +
            "8) Выход");

        int run = ReadRun();

        switch (run)
        {
            case 1:
                Console.WriteLine("Вы выбрали сложение");

                a = ReadDouble("Введите первое слагаемое: ");
                b = ReadDouble("Введите второе слагаемое: ");

                result = Calculator.Add(a, b);
                Console.WriteLine($"Результат: {result}");
                break;
            case 2:
                Console.WriteLine("Вы выбрали вычитание");

                a = ReadDouble("Введите уменьшаемое: ");
                b = ReadDouble("Введите вычитаемое: ");

                result = Calculator.Subtract(a, b);
                Console.WriteLine($"Результат: {result}");
                break;
            case 3:
                Console.WriteLine("Вы выбрали умножение");

                a = ReadDouble("Введите первый множитель: ");
                b = ReadDouble("Введите второй множитель: ");

                result = Calculator.Multiply(a, b);
                Console.WriteLine($"Результат: {result}");
                break;
            case 4:
                Console.WriteLine("Вы выбрали деление");

                a = ReadDouble("Введите делимое: ");
                b = ReadDouble("Введите делитель: ");

                result = Calculator.Divide(a, b);
                Console.WriteLine($"Результат: {result}");
                break;
            case 5:
                Console.WriteLine("Вы выбрали возведение в степень");

                a = ReadDouble("Введите основание: ");
                b = ReadDouble("Введите показатель: ");

                result = Calculator.Pow(a, b);
                Console.WriteLine($"Результат: {result}");
                break;
            case 6:
                Console.WriteLine("Вы выбрали отстаток от деления");

                a = ReadDouble("Введите делимое: ");
                b = ReadDouble("Введите делитель: ");

                result = Calculator.Mod(a, b);
                Console.WriteLine($"Результат: {result}");
                break;
            case 7:
                Console.WriteLine("Вы выбрали показ истории");
                break;
            case 8:
                Console.WriteLine("выход");
                break;
        }

        static int ReadRun() 
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out int choice) && choice >= 0 && choice <= 8)
                return choice;

            Console.WriteLine("Ошибка ввода. Пожалуйста, введите число от 0 до 8.");
            return ReadRun(); 
        }

        static double ReadDouble(string prompt)
        {
            Console.Write(prompt);
            string s = Console.ReadLine();
            if (double.TryParse(s, out double val))
                return val;

            Console.WriteLine("Некорректное число. Попробуйте ещё раз.");
            return ReadDouble(prompt);
        }  
    }
    static class Calculator
    {
        public static double Add(double a, double b) => a + b;
        public static double Subtract(double a, double b) => a - b;
        public static double Multiply(double a, double b) => a * b;

        public static double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Ошибка: деление на ноль!");
                return double.NaN;
            }
            return a / b;
        }

        public static double Pow(double a, double b) => Math.Pow(a, b);
        public static double Mod(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Ошибка: деление на ноль!");
                return double.NaN;
            }
            return a % b;
        }
    }
}