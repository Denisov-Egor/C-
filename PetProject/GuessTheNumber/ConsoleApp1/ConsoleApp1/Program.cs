using System;

public class GuessTheNumber
{
    static void Main()
    {
        bool playAgain = true;

        while (playAgain)
        {
            int min;
            int max, maxAttempts;
            int guess;
            int secret;
            int attempts = 0;

            Random rnd = new Random();

            Console.WriteLine("*******************************");
            Console.WriteLine("  Угадай число – версия 1.0");
            Console.WriteLine("*******************************\n");

            while (true)
            {
                Console.Write("Введите минимальную границу: ");
                min = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите максимальную границу: ");
                max = Convert.ToInt32(Console.ReadLine());

                if (min <= max) break;
                Console.WriteLine("Ошибка: минимум должен быть меньше максимума");
            }

            while (true)
            {
                Console.Write("Введите максимальное кол-во попыток: ");
                maxAttempts = Convert.ToInt32(Console.ReadLine());

                if (maxAttempts > 0) break;
                Console.WriteLine("Ошибка: у вас не может быть колличесво помыток <= 0");
            }

            secret = rnd.Next(min, max);

            Console.WriteLine($"Загаданное число: {secret}");

            while (true)
            {
                Console.Write("Введите вашу догадку: ");
                guess = Convert.ToInt32(Console.ReadLine());

                attempts++;
                Console.WriteLine($"Попытка {attempts} из {maxAttempts}");

                if (attempts > maxAttempts)
                {
                    Console.WriteLine("Вы проиграли! Попытки закончились.");
                    Console.WriteLine($"Загаданное число было: {secret}");
                    break;
                }

                if (guess < secret)
                {
                    Console.WriteLine("Ваше число меньше загаданного! ");
                }
                else if (guess > secret)
                {
                    Console.WriteLine("Ваше число больше загаданного! ");
                }
                else if (guess == secret)
                {
                    Console.WriteLine("Ваше число равно загаданному ");
                    break;
                }
            }

            while (true)
            {
                Console.Write("\nХотите сыграть ещё? (y/n): ");
                string response = Console.ReadLine().Trim().ToLower();
                if (response == "y")
                {
                    break;
                }
                else if (response == "n")
                {
                    playAgain = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Пожалуйста, введите 'y' или 'n'.");
                }
            }
        }
            Console.WriteLine("Спасибо за игру! До свидания.");
    }    
}