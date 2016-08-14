using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Judge
    {
        private Board m_Board;
        
        public Judge(Board m)
        {
            m_Board = m;
        }
        public bool CheckRules(int[] colRow)
        {
            int col1 = colRow[0];
            int row1 = colRow[1];
            int col2 = colRow[2];
            int row2 = colRow[3];

            Figure figure1 = m_Board.place[col1, row1].Figure;
            Figure figure2 = m_Board.place[col2, row2].Figure;

            ////pawn transformation condition
            //for (int i = 0; i<8; i++)
            //{
            //    if (m_Board.place[i, 0].Figure != null)
            //    {
            //        if(m_Board.place[i, 0].Figure.symbol == "1")
            //        {
            //            m_Board.place[i, 0].Figure.symbol = "5";
            //        }
            //    }
            //}

            if (figure1 != null)
            {
                return figure1.IsValidMove(col1, row1, col2, row2, m_Board);
            }
            return false;
            
        }
        public bool CheckRulesEnemy(int[] colRow)
        {
            int col1 = colRow[0];
            int row1 = colRow[1];
            int col2 = colRow[2];
            int row2 = colRow[3];

            Figure figure1 = m_Board.place[col1, row1].Figure;
            Figure figure2 = m_Board.place[col2, row2].Figure;

            if (m_Board.place[col1, row1].Figure != null)
            {
                if (figure1.IsBlack != true)
                {
                    return figure1.IsValidMove(col1, row1, col2, row2, m_Board);
                }
                return false;
            }
            else
            {
                return false;
            }
        }

    }
}


