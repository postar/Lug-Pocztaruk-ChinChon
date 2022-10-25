using System.Collections.Generic;

namespace BEL
{
    public abstract class Deck
    {
        protected List<Card> cards = new List<Card>();

        public List<Card> Cards
        {
            get { return cards; }
        }

        public void ResetDeck()
        {

        }
    }
}