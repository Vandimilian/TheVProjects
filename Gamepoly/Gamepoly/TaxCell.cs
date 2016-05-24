using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamepoly
{
    class TaxCell : Cell
    {
        private int tax;
        public TaxCell(string name, int tax, int height, int width) : base (name, height, width)
        {
            this.tax = tax;
        }

        public int getTax()
        {
            return tax;
        }
    }
}
