// See https://aka.ms/new-console-template for more information

namespace System
{
    class MyApp
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            String player;
            String computer;
            String restart;

            while (playAgain)
            {
                player = "";
                computer = "";
                restart = "";
  
                while (player != "камень" && player != "ножницы" && player != "бумага")
                {
                    Console.Write("Выберите КАМЕНЬ, НОЖНИЦЫ или БУМАГА: ");
                    player = Console.ReadLine();
                }
      
                switch (random.Next(1, 4))
                {
                    case 1:
                        computer = "камень";
                        break;

                    case 2:
                        computer = "ножницы";
                        break;

                    case 3:
                        computer = "бумага";
                        break;
                }

                Console.WriteLine("Ввел игрок: " + player);
                Console.WriteLine("Ввел компьютер: " + computer);

                switch (player)
                {
                    case "камень":
                        if (player == computer)
                        {
                            Console.WriteLine("ничья");
                        }
                        else if (computer == "бумага")
                        {
                            Console.WriteLine("Ты проиграл");
                        }
                        else 
                        {
                            Console.WriteLine("Ты выиграл");
                        }
                        break;

                    case "ножницы":
                        if (player == computer)
                        {
                            Console.WriteLine("ничья");
                        }
                        else if (computer == "камень")
                        {
                            Console.WriteLine("Тыпроиграл");
                        }
                        else 
                        {
                            Console.WriteLine("Тывыиграл");
                        }
                        break;

                    case "бумага":
                        if (player == computer)
                        {
                            Console.WriteLine("ничья");
                        }
                        else if (computer == "ножницы")
                        {
                            Console.WriteLine("Ты проиграл");
                        }
                        else 
                        {
                            Console.WriteLine("Ты выиграл");
                        }
                        break;
                }

                Console.Write("Ты хочешь продолжить игру (ДА или НЕТ): ");
                restart = Console.ReadLine();
                restart = restart.ToUpper();

                if (restart == "ДА")
                {
                    playAgain = true;
                }
                else
                {
                playAgain = false;
                }
            }
            Console.WriteLine("спасибо за игру!");
        }
    }
}