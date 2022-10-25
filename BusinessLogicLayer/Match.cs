using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BEL
{
    public class Match
    {
        private CyclicList<Player> participant;

        public void Start(Player player1, Player player2)
        {
            participant = new CyclicList<Player>(player1, player2);
        }

        public Player End()
        {

            throw new System.NotImplementedException();
        }
    }
}