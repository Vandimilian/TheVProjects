using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamepoly
{
    class Player
    {
        protected PropertyCell [] properties;
        protected TrainCell [] trainCells;
        protected CompanyCell [] companyCells;

        protected string name;
        protected int money;
        protected int position;


        public Player(string name, int money)
        {
            this.name = name;
            this.money = money;
            position = 0;
        }

        public void addPropertyCell()
        {
            // TO DO
        }

        public void addTrainCell()
        {
            // TO DO
        }

        public void addCompanyCell()
        {
            // TO DO
        }

        public void movePlayer(int num)
        {
            // TO DO
        }

        public void setMoney(int money)
        {
            this.money = money;
        }

        public int getMoney()
        {
            return money;
        }

        public int getPosition()
        {
            return position;
        }
    }
}
