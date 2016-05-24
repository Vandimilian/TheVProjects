using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamepoly
{
    class CompanyCell : Cell
    {
        protected int cellPrice;
        public CompanyCell(string name, int price, int height, int width) : base(name, height, width)
        {
            cellPrice = price;
        }
    }
}
