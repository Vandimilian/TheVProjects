using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamepoly
{
    class ParkingCell : Cell
    {
        protected int jackpot;

        public ParkingCell() : base("Free Parking",91,91)
        {
            jackpot = 0;
        }
        public void addToJackpot(int money)
        {
            jackpot += money;
        }

        public int getJackPot()
        {
            int pot = jackpot;
            jackpot = 0;
            return pot;
        }
    }

}
