using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamepoly
{
    class TrainCell : Cell
    {
        protected int cellPrice;

        public TrainCell(string name, int cellPrice, int height, int width) : base (name, height, width)
        {
            this.cellPrice = cellPrice;
        }

        public void setCellPrice(int price)
        {
            cellPrice = price;
        }

        public int getCellPrice()
        {
            return cellPrice;
        }
    }
}
