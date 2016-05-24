using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamepoly
{
    class PropertyCell : Cell
    {
        protected int cellPrice;
        protected int housePrice;
        protected int rent;
        protected string color;
        protected int numHouses;

        public PropertyCell(string name, int cellPrice, int housePrice, string color, int height, int width) : base (name, height, width)
        {
            this.cellPrice = cellPrice;
            this.housePrice = housePrice;
            this.color = color;
            numHouses = 0;
        }

        public void setCellPrice(int price)
        {
            cellPrice = price;
        }

        public int getCellPrice()
        {
            return cellPrice;
        }

        public int getHousePrice()
        {
            return housePrice;
        }

        public void setHousePrice(int price)
        {
            housePrice = price;
        }

        public int getRent()
        {
            return rent;
        }
        
        public void setRent(int rent)
        {
            this.rent = rent;
        }

        public string getColor()
        {
            return color;
        }

        public void setColor(string color)
        {
            this.color = color;
        }

        public void setNumHouses(int number)
        {
            numHouses = number;
        }

        public int getNumHouses()
        {
            return numHouses;
        }


    }
}
