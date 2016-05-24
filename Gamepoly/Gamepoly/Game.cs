using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamepoly
{
    class Game
    {

        private Board myBoard;
        private int numPlayers;
        private Player [] players;
        private int turn;
        private const int STARTMONEY = 1500;
        private int dice;

        public Game(string [] names)
        {
            myBoard = new Board(this);
            numPlayers = names.Length;
            players = new Player[numPlayers];

            for (int i = 0; i < numPlayers; i++)
            {
                players[i] = new Player(names[i], STARTMONEY);
            }
            

        }
    }
}
