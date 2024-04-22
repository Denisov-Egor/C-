using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;

            Random random = new Random();
            int min = 1;
            int max = 10;

            int guess;
            int number;
            int guesses;
            String Response;

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                number = random.Next(min, max + 1);
                Response = " ";

                while (guess != number)
                {
                    Console.WriteLine("Введите число от " + min + " - " + max + " : ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Твое число: " + guess);

                    if (guess > number)
                    {
                        Console.WriteLine("Это высокое число!");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine("Это маленькое число!");
                    }
                    guesses++;
                }
                Console.WriteLine("Твои попытки " + guesses + "!");
                Console.WriteLine("ты выиграл!!!");
                Console.WriteLine("Хотели бы вы сыграть еще раз? Ответьте да или нет.");

                Response = Console.ReadLine();

                if (Response == "да")
                {
                    Console.Write("Ладно, поехали!");
                    playAgain = true;

                }
                else
                {
                    Console.WriteLine("Ааа, ладно: Спасибо, что поиграл со мной...");
                    playAgain = false;
                }
            }
        }
    }
}