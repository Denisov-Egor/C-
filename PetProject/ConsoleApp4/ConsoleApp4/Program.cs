using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int numberToGuess = random.Next(1, 101);
        int attempts = 0;
        bool hasWon = false;

        Console.WriteLine("Добро пожаловать в игру 'Угадай число'!");
        Console.WriteLine("Я загадала число от 1 до 100. Попробуйте угадать его!");

        while (!hasWon)
        {
            attempts++;
            Console.Write($"Попытка {attempts}. Введите ваше предположение: ");
            int userGuess;

            if (int.TryParse(Console.ReadLine(), out userGuess))
            {
                if (userGuess < numberToGuess)
                {
                    Console.WriteLine("Меньше. Попробуйте еще раз.");
                }
                else if (userGuess > numberToGuess)
                {
                    Console.WriteLine("Больше. Попробуйте еще раз.");
                }
                else
                {
                    hasWon = true;
                    Console.WriteLine($"Поздравляю! Вы угадали число {numberToGuess} за {attempts} попыток!");
                }
            }
            else
            {
                Console.WriteLine("Ошибка: Введите корректное число.");
            }
        }
    }
}