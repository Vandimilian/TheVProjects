using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamepoly
{
    class Board
    {
        private Game myGame;
        private Cell[] cells;
        private const int NUMBEROFCELLS = 40;
        private const int HEIGHTBOARD = 700;
        private const int WIDTHBOARD = 700;
        public Board(Game g)
        {
            myGame = g;

            cells = new Cell[NUMBEROFCELLS];

            cells[0] = new Cell("Departure",91,91);
            cells[1] = new PropertyCell("Mediterranean Avenue", 60, 50, "brown",91,57);
            cells[2] = new CardCell("Comunity chest",2, 91, 57);
            cells[3] = new PropertyCell("Baltic Avenue", 60, 50 , "brown", 91, 57);
            cells[4] = new TaxCell("Income Tax",200, 91, 57);
            cells[5] = new TrainCell("Reading Railroad", 200, 91, 57);
            cells[6] = new PropertyCell("Oriental Avenue", 100, 50, "lBlue", 91, 57);
            cells[7] = new CardCell("Chance", 1, 91, 57);
            cells[8] = new PropertyCell("Vermont Avenue", 100, 50, "lBlue", 91, 57);
            cells[9] = new PropertyCell("Connecticut Avenue", 10, 50, "lBlue", 91, 57);
            cells[10] = new JailCell();
            cells[11] = new PropertyCell("St. Charles Place", 140, 100, "purple", 57, 91);
            cells[12] = new CompanyCell("Electric Company", 150, 57, 91);
            cells[13] = new PropertyCell("States Avenue", 140, 100, "purple", 57, 91);
            cells[14] = new PropertyCell("Virginia Avenue", 160, 100, "purple", 57, 91);
            cells[15] = new TrainCell("Pennsylvania Railroad", 200, 57, 91);
            cells[16] = new PropertyCell("St. James Place", 180, 100, "orange", 57, 91);
            cells[17] = new CardCell("Comunity chest", 2, 57, 91);
            cells[18] = new PropertyCell("Tenesse Avenue", 180, 100, "orange", 57, 91);
            cells[19] = new PropertyCell("New York Avenue", 200, 100, "orange", 57, 91);
            cells[20] = new ParkingCell();
            cells[21] = new PropertyCell("Kentucky Avenue", 220, 150, "red", 91, 57);
            cells[22] = new CardCell("Chance", 1, 91, 57);
            cells[23] = new PropertyCell("Indiana Avenue", 220, 150, "red", 91, 57);
            cells[23] = new PropertyCell("Illinois Avenue", 240, 150, "red", 91, 57);
            cells[24] = new TrainCell("B & Q Railroad", 200, 91, 57);
            cells[25] = new PropertyCell("Atlantic Avenue", 260, 150, "yellow", 91, 57);
            cells[26] = new PropertyCell("Ventinor Avenue", 260, 150, "yellow", 91, 57);
            cells[27] = new CompanyCell("Water Company", 150, 91, 57);
            cells[28] = new PropertyCell("Marvin Gardens", 280, 150, "yellow", 91, 57);
            cells[29] = new GoToJailCell();
            cells[30] = new PropertyCell("Pacific Avenue", 300, 200, "green", 57, 91);
            cells[31] = new PropertyCell("North Carolina Avenue", 300, 200, "green", 57, 91);
            cells[32] = new CardCell("Comunity chest", 2, 57, 91);
            cells[33] = new PropertyCell("Pennsylvania Avenue", 320, 200, "green", 57, 91);
            cells[34] = new TrainCell("Short Line", 200, 57, 91);
            cells[35] = new CardCell("Chance", 1, 57, 91);
            cells[36] = new PropertyCell("Park Place", 350, 200, "blue", 57, 91);
            cells[37] = new TaxCell("Luxury Tax",100, 57, 91);
            cells[38] = new PropertyCell("Black Leg Place", 400, 200, "blue", 57, 91);


            int countX = HEIGHTBOARD;
            int countY = WIDTHBOARD;
            int cellCounter = 0;
            /*
            for (int i = 0; i < NUMBEROFCELLS / 10; i++)
            {
                if (i == 0)
                    for (int j = 0; j < NUMBEROFCELLS / 4; j++)
                    {
                        if (j == 0)
                        {
                            // We use the Heigth and Width of the first cell like pattern
                            countX -= cells[0].getWidth();
                            countY -= cells[0].getHeight();

                            cells[cellCounter].setX(countX);
                            cells[cellCounter].setY(countY);

                            cellCounter++;
                        }
                        else
                        {
                            countX -= cells[i * j].getWidth();

                            cells[cellCounter].setX(countX);
                            cells[cellCounter].setY(countY);

                            cellCounter++;
                        }
                    }
                else if (i == 1)
                    for (int j = 0; j < NUMBEROFCELLS / 4; j++)
                    {
                        if (j == 0)
                        {
                            // We use the Heigth and Width of the first cell like pattern
                            countX -= cells[0].getWidth();

                            cells[cellCounter].setX(countX);
                            cells[cellCounter].setY(countY);

                            cellCounter++;
                        }
                        else
                        {
                            countY -= cells[cellCounter].getHeight();

                            cells[cellCounter].setX(countX);
                            cells[cellCounter].setY(countY);

                            cellCounter++;
                        }
                    }
                else if (i == 2)
                    for (int j = 0; j < NUMBEROFCELLS / 4; j++)
                    {
                        if (j == 0)
                        {
                            // We use the Heigth and Width of the first cell like pattern
                            countY -= cells[cellCounter].getHeight();

                            cells[cellCounter].setX(countX);
                            cells[cellCounter].setY(countY);

                            cellCounter++;
                        }
                        else
                        {
                            countY += cells[cellCounter].getHeight();

                            cells[cellCounter].setX(countX);
                            cells[cellCounter].setY(countY);

                            cellCounter++;
                        }
                    }
            }
            */
        }
        public Cell getCell(int index)
        {
            return cells[index];
        }
    }
}
