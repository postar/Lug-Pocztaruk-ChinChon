using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogicLayer
{
    public class GameDeck:Deck
    {
        public void CreateDeck()
        {
            Suit.Name[] regularSuits = { Suit.Name.Copa, Suit.Name.Espada, Suit.Name.Oro, Suit.Name.Basto };
            foreach (Suit.Name suit in regularSuits)
            {
                for (int i = 1; i < 13; i++)
                    cards.Add(new Card(suit, i));
            }
            for (int i = 0; i < 2; i++)
                cards.Add(new Card(Suit.Name.Comodin, i));
        }
    }

}