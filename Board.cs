using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Board
    {
        enum Weather
        {
            Day,
            Night,
            Rain
        }

        public Player Player;
        private Player computer;
        private bool volcanoState;
        private int turn;

        public Board()
        {
            Player = new Player();
            computer = new Player();
            volcanoState = false;
            turn = 1;

        }


        public void calculateVolcanoState(int round)
        {
            Random random = new Random();

            if (random.Next() % 20 <= round)
            {
                volcanoState = true;
            }
        }
    }
}
