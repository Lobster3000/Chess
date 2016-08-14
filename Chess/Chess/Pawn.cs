using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Pawn : Figure
    {
        public Pawn(bool isBlack) : base(isBlack)
        {
            symbol = "1";
        }

        public override bool IsValidMove(int fromCol, int fromRow, int toCol, int toRow, Board board)
        {
            Figure figure1 = board.place[fromCol, fromRow].Figure;
            Figure figure2 = board.place[toCol, toRow].Figure;

        	int offset = m_IsBlack ? -1 : 1;

            if (figure2 == null)
        	{
                if (toCol == fromCol && toRow == fromRow + offset * 2)
                {
                    if(fromRow == 6 && figure1.IsBlack == true || fromRow == 1 && figure1.IsBlack == false)
                    {
                        if (board.place[fromCol, fromRow + offset].Figure == null)
                        {
                            return true;
                        }
                    }
                }

                if (toCol == fromCol && toRow == fromRow + offset)
                {
                    return true;
                }
            } 
            else 
            {
            	if (figure2.IsBlack != this.IsBlack) 
            	{
            		if (Math.Abs(toCol - fromCol) == 1 && toRow == fromRow + offset)
					{
	                    return true;
	                }
            	}
            }
            return false;
        }
    }
}
