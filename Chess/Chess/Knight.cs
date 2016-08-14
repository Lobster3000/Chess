using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Knight : Figure
    {
        public Knight(bool isBlack) : base(isBlack)
        {
            symbol = "3";
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
                if (toCol == fromCol + 2 && toRow == fromRow - 1)
                {
                    return true;
                }
                if (toCol == fromCol + 1 && toRow == fromRow - 2)
                {
                    return true;
                }
                if (toCol == fromCol - 1 && toRow == fromRow - 2)
                {
                    return true;
                }
                if (toCol == fromCol - 2 && toRow == fromRow - 1)
                {
                    return true;
                }
                if (toCol == fromCol - 2 && toRow == fromRow + 1)
                {
                    return true;
                }
                if (toCol == fromCol - 1 && toRow == fromRow + 2)
                {
                    return true;
                }
                if (toCol == fromCol + 1 && toRow == fromRow + 2)
                {
                    return true;
                }
                if (toCol == fromCol + 2 && toRow == fromRow + 1)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
