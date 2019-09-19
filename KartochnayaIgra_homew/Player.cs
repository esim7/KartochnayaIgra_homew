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

        public Player()
        {
            Name = string.Empty;
            PlayerCards = new List<Card>();
            PointCount = 0;
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
