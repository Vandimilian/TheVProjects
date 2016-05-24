using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamepoly
{
    class CardCell : Cell
    {
        Card[] chanceCards;
        Card[] comunityCards;
        int classOfCard;
        public CardCell(string name, int classOfCard, int height, int width) : base(name, height, width)
        {
            // 1 for the chance cards
            // 2 for the comunity cards
            this.classOfCard = classOfCard;
        }

        public Card getRandomCard()
        {
            // TO DO
            return new Card();
        }
    }
}
