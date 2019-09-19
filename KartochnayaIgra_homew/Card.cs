using System;
using System.Collections.Generic;
using System.Text;

namespace KartochnayaIgra_homew
{
    public class Card
    {
        public string CardSuit { get; } //масть карты
        public CardType CardType { get; } //6-10 валет дама и т.д

        public Card(string cardSuit, CardType cardType)
        {
            CardSuit = cardSuit;
            CardType = cardType;
        }
    }
}
