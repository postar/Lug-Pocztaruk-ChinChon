using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BEL
{
    public class Player
    {
        private int score;

        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        public void Cut()
        {
            throw new System.NotImplementedException();
        }
    }
}