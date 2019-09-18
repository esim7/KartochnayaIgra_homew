using System;
using System.Collections.Generic;
using System.Text;

namespace KartochnayaIgra_homew
{
    public class CardDeck
    {
        List<Card> Deck { get; set; }

        public CardDeck()
        {
            Deck = new List<Card>
            {
                new Card("ПИКИ", "6"), new Card("ПИКИ", "7"), new Card("ПИКИ", "8"), new Card("ПИКИ", "9"), new Card("ПИКИ", "10"), new Card("ПИКИ", "ВАЛЕТ"), new Card("ПИКИ", "ДАМА"), new Card("ПИКИ", "КОРОЛЬ"), new Card("ПИКИ", "ТУЗ"),
                new Card("ЧЕРВИ", "6"), new Card("ЧЕРВИ", "7"), new Card("ЧЕРВИ", "8"), new Card("ЧЕРВИ", "9"), new Card("ЧЕРВИ", "10"), new Card("ЧЕРВИ", "ВАЛЕТ"), new Card("ЧЕРВИ", "ДАМА"), new Card("ЧЕРВИ", "КОРОЛЬ"), new Card("ЧЕРВИ", "ТУЗ"),
                new Card("КРЕСТИ", "6"), new Card("КРЕСТИ", "7"), new Card("КРЕСТИ", "8"), new Card("КРЕСТИ", "9"), new Card("КРЕСТИ", "10"), new Card("КРЕСТИ", "ВАЛЕТ"), new Card("КРЕСТИ", "ДАМА"), new Card("КРЕСТИ", "КОРОЛЬ"), new Card("КРЕСТИ", "ТУЗ"),
                new Card("БУБЕН", "6"), new Card("БУБЕН", "7"), new Card("БУБЕН", "8"), new Card("БУБЕН", "9"), new Card("БУБЕН", "10"), new Card("БУБЕН", "ВАЛЕТ"), new Card("БУБЕН", "ДАМА"), new Card("БУБЕН", "КОРОЛЬ"), new Card("БУБЕН", "ТУЗ"),
            };
        }
    }
}
