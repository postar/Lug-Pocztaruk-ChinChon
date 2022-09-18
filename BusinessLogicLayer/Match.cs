using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogicLayer
{
    public class Match
    {
        private Player player1;

        public Player Player1
        {
            get { return player1; }
            set { player1 = value; }
        }

        private Player player2;

        public Player Player2
        {
            get { return player2; }
            set { player2 = value; }
        }

        public Match(Player player1, Player player2)
        {
            var List = new CyclicList<Player>(player1, player2);
        }

        public void Start()
        {
            throw new System.NotImplementedException();
        }

        public void End()
        {
            throw new System.NotImplementedException();
        }
    }
}