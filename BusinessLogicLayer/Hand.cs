using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogicLayer
{
    public class Hand
    {
        private List<Card> content;

        public List<Card> Content
        {
            get { return content; }
            set { content = value; }
        }

        public void DropCard(Card card)
        {
            throw new System.NotImplementedException();
        }

        public void PickCard(Card card)
        {
            throw new System.NotImplementedException();
        }
    }
}