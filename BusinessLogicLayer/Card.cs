using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogicLayer
{
    public class Card
    {
        private int number;

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        private Suit.Name suit;

        public Suit.Name Suit
        {
            get { return suit; }
            set { suit = value; }
        }

        public Card(Suit.Name suit, int number)
        {
            this.suit = suit;
            this.number = number;
        }
    }
}