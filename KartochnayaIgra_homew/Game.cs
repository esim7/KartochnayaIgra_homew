﻿using System;
using System.Collections.Generic;
using System.Text;

namespace KartochnayaIgra_homew
{
    public class Game
    {
        const int PlayersCount = 2;

        public Random random = new Random();
        public List<Player> Players { get; set; }
        public CardDeck CardDeck { get; set; }
        public bool isGameActive = true;

        public void ShufflingCards()//перетасовка карт
        {
            for (int i = 0; i < CardDeck.Deck.Count; i++)
            {
                Card temp = CardDeck.Deck[i];
                CardDeck.Deck.RemoveAt(i);
                CardDeck.Deck.Insert(random.Next(CardDeck.Deck.Count), temp);
            }
        }

        public Game()
        {
            CardDeck = new CardDeck();
            Players = new List<Player>()
            {
                new Player(),
                new Player()
            };   
        }

        public void PlayerInitialization()
        {
            for (int i = 0; i < PlayersCount; i++)
            {
                Console.WriteLine("Введите имя игрока №" + (i + 1));
                Players[i].Name = Console.ReadLine();
            }
        }
        public void DealCards()
        {
            while (CardDeck.Deck.Count > 0)
                for (int i = 0; i < Players.Count; i++)
                {
                    Players[i].PlayerCards.Add(CardDeck.Deck[0]);
                    Players[i].PointCount = Players[i].PlayerCards.Count;
                    CardDeck.Deck.Remove(CardDeck.Deck[0]);
                }
        }

        public void StartGame()
        {
            int firstMove = 0;
            bool selectFirstMove = true;
            if(selectFirstMove)
            {
                Console.WriteLine("Добро пожаловать в карточную игру. Чтобы случайно определить какой игрок будет делать первый ход нажмите любую кнопку");
                Console.ReadKey();
                firstMove = random.Next(0, 2); //рандомно определяем кто из игроков ходит первый
                Console.WriteLine("Первый ход за игроком " + Players[firstMove].Name);
                Console.ReadKey();
                Console.Clear();
                if (firstMove == 1)
                {
                    var buf = Players[0];
                    Players[0] = Players[1];
                    Players[1] = buf;
                }
            }
            while(Players.Count > 1)
            {
                Console.Clear();
                Console.SetCursorPosition(10, 8);
                Console.WriteLine(Players[0].Name + " нажмите на любую кнопку чтобы сделать ход\n");                
                Console.ReadKey();
                Console.SetCursorPosition(20, 10);
                Console.WriteLine("Карт у игрока:  " + Players[0].PointCount);
                Console.SetCursorPosition(20, 11);
                Console.WriteLine(Players[0].Name);
                Console.SetCursorPosition(20, 12);
                Console.WriteLine(Players[0].PlayerCards[0].CardSuit);
                Console.SetCursorPosition(20, 13);
                Console.WriteLine(Players[0].PlayerCards[0].CardType);
                Console.SetCursorPosition(60, 8);
                Console.WriteLine(Players[1].Name + " нажмите на любую кнопку чтобы сделать ход");
                Console.ReadKey();
                Console.SetCursorPosition(70, 10);
                Console.WriteLine("Карт у игрока " + Players[1].PointCount);
                Console.SetCursorPosition(70, 11);
                Console.WriteLine(Players[1].Name);
                Console.SetCursorPosition(70, 12);
                Console.WriteLine(Players[1].PlayerCards[0].CardSuit);
                Console.SetCursorPosition(70, 13);
                Console.WriteLine(Players[1].PlayerCards[0].CardType);
                
                if((int)Players[0].PlayerCards[0].CardType > (int)Players[1].PlayerCards[0].CardType)
                {
                    Players[0].PlayerCards.Add(Players[1].PlayerCards[0]);
                    Players[0].PlayerCards.Add(Players[0].PlayerCards[0]);
                    Players[0].PlayerCards.Remove(Players[0].PlayerCards[0]);
                    Players[1].PlayerCards.Remove(Players[1].PlayerCards[0]);
                    Players[0].PointCount++;
                    Players[1].PointCount--;
                    Console.SetCursorPosition(46, 20);
                    Console.WriteLine("Раунд выйграл игрок " + Players[0].Name);
                    if (Players[1].PlayerCards.Count == 0)
                        Players.RemoveAt(0);
                }
                else
                {
                    Players[1].PlayerCards.Add(Players[0].PlayerCards[0]);
                    Players[1].PlayerCards.Add(Players[1].PlayerCards[0]);
                    Players[1].PlayerCards.Remove(Players[1].PlayerCards[0]);
                    Players[0].PlayerCards.Remove(Players[0].PlayerCards[0]);
                    Console.SetCursorPosition(46, 20);
                    Console.WriteLine("Раунд выйграл игрок " + Players[1].Name);
                    Players[1].PointCount++;
                    Players[0].PointCount--;
                    if (Players[0].PlayerCards.Count == 0)
                        Players.RemoveAt(1);
                }
                Console.ReadKey();
            }
        }

        public void ShowCardDeck()
        {
            foreach (Card card in CardDeck.Deck)
            {
                Console.WriteLine(card.CardSuit + "  " + card.CardType);
            }
        }

        public void ShowWinerPlayer()
        {
            Console.Clear();
            Console.SetCursorPosition(45, 10);
            Console.ForegroundColor = ConsoleColor.Red;
            foreach (Player player in Players)
            { 
                Console.WriteLine($"Игрок {player.Name} победил");
            }
            isGameActive = false;
        }
    }
}
