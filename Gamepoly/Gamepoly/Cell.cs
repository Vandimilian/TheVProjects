using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamepoly
{
    class Cell
    {
        protected string name;
        protected Player owner;
        protected int height;
        protected int width;
        protected int x;
        protected int y;
        public Cell(string name, int height, int width)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }

        public void addOwner(Player owner)
        {
            this.owner = owner;
        }

        public void setX(int x)
        {
            this.x = x;
        }

        public void setY(int y)
        {
            this.y = y;
        }
        
        public int getHeight()
        {
            return height;
        }

        public int getWidth()
        {
            return width;
        }
    }
}
