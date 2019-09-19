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
                            int num = random.Next(0, 2);
                            Console.WriteLine(num);
                            var buf = game.Players[0];
                            game.Players[0] = game.Players[1];
                            game.Players[1] = buf;
                            Console.WriteLine(game.Players[0].Name);
                            Console.WriteLine(game.Players[1].Name);
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
                        }
                        break;
                    case "4":
                        {
                            isActive = false;
                        }
                        break;
                }
                Console.ReadLine();
            } while (isActive != false);
            //Game game = new Game();
            //game.ShowCardDeck();
            //Console.WriteLine("___________________________________________");
            //game.ShufflingCards();
            //game.ShowCardDeck();
            //game.DealCards();
            ////Console.WriteLine("Карты после тасовки");
            ////game.ShowCardDeck();
            ////Console.WriteLine("Карты игрока 1");
            ////game.Players[0].ShowMyCards();
            ////Console.WriteLine("Карты игрока 2");
            ////game.Players[1].ShowMyCards();
            ////Console.ReadKey();
        }
    }
}
