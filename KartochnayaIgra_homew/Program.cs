using System;

namespace KartochnayaIgra_homew
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Game game = new Game();
            bool isActive = true;
            string key;
            do
            {
                Console.Clear();
                Console.WriteLine("1. Зарегистрировать игроков \n2. Перетасовать колоду \n3. Начать игру" +
                    "\n4. Выход");
                key = Console.ReadLine();
                switch (key)
                {
                    case "1":
                        {
                            game.PlayerInitialization();
                        }
                        break;
                    case "2":
                        {
                            game.ShufflingCards();                          
                        }
                        break;
                    case "3":
                        {
                            game.DealCards();
                            game.StartGame();
                            game.ShowWinerPlayer();
                        }
                        break;
                    case "4":
                        {
                            isActive = false;
                        }
                        break;
                }
                Console.ReadLine();
            } while (isActive != false && game.isGameActive != false);
        }
    }
}
