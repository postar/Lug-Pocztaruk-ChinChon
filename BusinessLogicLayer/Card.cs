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

        private Suit suit;

        public Suit Suit
        {
            get { return suit; }
            set { suit = value; }
        }
    }
}