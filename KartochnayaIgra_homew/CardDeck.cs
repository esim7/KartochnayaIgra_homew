using System;
using System.Collections.Generic;
using System.Text;

namespace KartochnayaIgra_homew
{
    public class CardDeck
    {
        public List<Card> Deck { get; set; }

        public CardDeck()
        {
            Deck = new List<Card>
            {
                new Card("ПИКИ", CardType.ШЕСТЬ), new Card("ПИКИ", CardType.СЕМЬ), new Card("ПИКИ", CardType.ВОСЕМЬ), new Card("ПИКИ", CardType.ДЕВЯТЬ), new Card("ПИКИ", CardType.ДЕСЯТЬ), new Card("ПИКИ", CardType.ВАЛЕТ), new Card("ПИКИ", CardType.ДАМА), new Card("ПИКИ", CardType.КОРОЛЬ), new Card("ПИКИ", CardType.ТУЗ),
                new Card("ЧЕРВИ", CardType.ШЕСТЬ), new Card("ЧЕРВИ", CardType.СЕМЬ), new Card("ЧЕРВИ", CardType.ВОСЕМЬ), new Card("ЧЕРВИ", CardType.ДЕВЯТЬ), new Card("ЧЕРВИ", CardType.ДЕСЯТЬ), new Card("ЧЕРВИ", CardType.ВАЛЕТ), new Card("ЧЕРВИ", CardType.ДАМА), new Card("ЧЕРВИ", CardType.КОРОЛЬ), new Card("ЧЕРВИ", CardType.ТУЗ),
                new Card("КРЕСТИ", CardType.ШЕСТЬ), new Card("КРЕСТИ", CardType.СЕМЬ), new Card("КРЕСТИ", CardType.ВОСЕМЬ), new Card("КРЕСТИ", CardType.ДЕВЯТЬ), new Card("КРЕСТИ", CardType.ДЕСЯТЬ), new Card("КРЕСТИ", CardType.ВАЛЕТ), new Card("КРЕСТИ", CardType.ДАМА), new Card("КРЕСТИ", CardType.КОРОЛЬ), new Card("КРЕСТИ", CardType.ТУЗ),
                new Card("БУБЕН", CardType.ШЕСТЬ), new Card("БУБЕН", CardType.СЕМЬ), new Card("БУБЕН", CardType.ВОСЕМЬ), new Card("БУБЕН", CardType.ДЕВЯТЬ), new Card("БУБЕН", CardType.ДЕСЯТЬ), new Card("БУБЕН", CardType.ВАЛЕТ), new Card("БУБЕН", CardType.ДАМА), new Card("БУБЕН", CardType.КОРОЛЬ), new Card("БУБЕН", CardType.ТУЗ),
            };
        }
    }
}
