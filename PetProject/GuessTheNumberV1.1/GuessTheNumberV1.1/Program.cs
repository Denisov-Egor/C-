using System;

public class GuessTheNumber
{
    static void Main()
    {
        // Приветсвие
        ShowHeader();

        bool playAgain = true;
        while (playAgain)
        {
            GetRange(out int min, out int max);

            int rangeSize = max - min + 1;
            int minAttempts = ComputeMinAttempts(rangeSize);

            // Лимит попыток
            int maxAttempts = GetMaxAttempts(minAttempts);

            // Секрет
            int secret = GenerateSecret(min, max);

            // Раунд
            PlayRound(secret, min, max, minAttempts, maxAttempts);

            //Повтор 
            playAgain = AskToPlayAgain();
        }
        Console.WriteLine("Спасибо за игру! До свидания.");
    }

    private static void ShowHeader()
    {
        Console.WriteLine("*******************************");
        Console.WriteLine("  Угадай число – версия 1.1");
        Console.WriteLine("*******************************\n");
    }

    private static void GetRange(out int min, out int max)
    {
        while (true)
        {
            Console.Write("Введите минимальную границу: ");
            min = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите максимальную границу: ");
            max = Convert.ToInt32(Console.ReadLine());

            if (min <= max) break;
            Console.WriteLine("Ошибка: минимум должен быть меньше максимума");
        }
    }
        
    private static int ComputeMinAttempts(int rangeSize)
    {
        double minAttempts = Math.Log(rangeSize + 1, 2); 
        return (int)Math.Ceiling(minAttempts);
    }

    private static int GetMaxAttempts(int minAttempts)
    {
        Console.Write($"Введите максимальное количество попыток (по умолчанию 10, нажмите Enter): ");
        string line = Console.ReadLine();

        int maxAttempts = 10;
        if (!string.IsNullOrWhiteSpace(line) && int.TryParse(line, out int parsed) && parsed > 0)
            maxAttempts = parsed;

        if (maxAttempts < minAttempts)
        {
            Console.WriteLine(
                $"Введённое значение меньше теоретически необходимого ({minAttempts}). " +
                $"Устанавливаем maxAttempts = {minAttempts}.");
            maxAttempts = minAttempts;
        }

        Console.WriteLine($"\nТеоретически минимум попыток: {minAttempts}");
        Console.WriteLine($"Вы получаете {maxAttempts} попыток.\n");
        return maxAttempts;
    }

    private static int GenerateSecret(int min, int max)
    {
        Random rnd = new Random();
        return rnd.Next(min, max + 1); 
    }

    private static void PlayRound(int secret, int min, int max, int minAttempts, int maxAttempts)
    {
        int[] history = new int[maxAttempts];
        int attempts = 0;
        bool guessed = false;

        while (attempts < maxAttempts && !guessed)
        {
            attempts++;
            int guess = ReadGuess(attempts, maxAttempts, min, max);
            history[attempts - 1] = guess;

            guessed = EvaluateGuess(guess, secret, out string hint);
            Console.WriteLine(hint);
        }

        if (guessed)
            Console.WriteLine($"\nПоздравляем! Вы угадали число {secret} за {attempts} попыт{(attempts == 1 ? "ку" : "ок")}.");
        else
            Console.WriteLine($"\nПопытки закончились. Загаданное число было {secret}.");

        PrintHistory(history, attempts);
    }

    private static int ReadGuess(int attempt, int maxAttempts, int min, int max)
    {
        while (true)
        {
            Console.Write($"Попытка {attempt}/{maxAttempts}. Введите число ({min}‑{max}): ");
            string line = Console.ReadLine();

            if (line == null) Environment.Exit(0);

            if (int.TryParse(line, out int guess))
            {
                if (guess < min || guess > max)
                {
                    Console.WriteLine($"Число должно быть в диапазоне {min}‑{max}.");
                    continue;
                }
                return guess;
            }

            Console.WriteLine("Некорректный ввод. Попробуйте снова.");
        }
    }

    private static bool EvaluateGuess(int guess, int secret, out string hint)
    {
        if (guess == secret)
        {
            hint = "Угадал!";
            return true;
        }

        hint = guess < secret ? "Больше" : "Меньше";
        return false;
    }

    private static void PrintHistory(int[] history, int used)
    {
        Console.Write("\nИстория попыток: ");
        for (int i = 0; i < used; i++)
            Console.Write($"{history[i]} ");
        Console.WriteLine();
    }

    private static bool AskToPlayAgain()
    {
        Console.Write("\nХотите сыграть ещё раз? (y/n): ");
        string answer = Console.ReadLine()?.Trim().ToLower();
        return answer == "y" || answer == "yes";
    }
}