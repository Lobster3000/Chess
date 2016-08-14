using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class King : Figure
    {
        public King(bool isBlack) : base(isBlack)
        {
            symbol = "6";
        }

        public override bool IsValidMove(int fromCol, int fromRow, int toCol, int toRow, Board board)
        {
            Figure figure1 = board.place[fromCol, fromRow].Figure;
            Figure figure2 = board.place[toCol, toRow].Figure;

            if (figure2 != null && figure1.IsBlack == figure2.IsBlack)
            {
                return false;
            }
            else
            {
                if (toCol == fromCol && toRow == fromRow - 1)      //forward
                {
                    return true;
                }
                if (toCol == fromCol - 1 && toRow == fromRow)      //left
                {
                    return true;
                }
                if (toCol == fromCol && toRow == fromRow + 1)      //down
                {
                    return true;
                }
                if (toCol == fromCol + 1 && toRow == fromRow)      //right
                {
                    return true;
                }

                if (toCol == fromCol - 1 && toRow == fromRow - 1)      //north west
                {
                    return true;
                }
                if (toCol == fromCol + 1 && toRow == fromRow - 1)      // west south
                {
                    return true;
                }
                if (toCol == fromCol - 1 && toRow == fromRow + 1)      //south east
                {
                    return true;
                }
                if (toCol == fromCol + 1 && toRow == fromRow + 1)      //north east
                {
                    return true;
                }
            }
            return false;
        }
    }
}

