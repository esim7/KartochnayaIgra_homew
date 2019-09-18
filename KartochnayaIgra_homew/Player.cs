using System;
using System.Collections.Generic;
using System.Text;

namespace KartochnayaIgra_homew
{
    public class Player
    {
        public string Name { get; set; }
        public int PointCount { get; set; }
        public List<Card> PlayerCards { get; set; }

        public Player(string name)
        {
            Name = name;
            PointCount = 0;
            PlayerCards = new List<Card>();
        }

        public void ShowMyCards()
        {
            foreach(Card card in PlayerCards)
            {
                Console.WriteLine(card.CardSuit + "  " + card.CardType);
            }
        }
    }
}
