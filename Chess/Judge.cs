using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Judge
    {
        string pawn = "1";
        string rook = "2";
        string knight = "3";
        string bishop = "4";
        string queen = "5";
        string king = "6";
        Board board;
        bool blue = true;
        bool red = false;

        public Judge(Board m)
        {
            board = m;
        }
        public bool CheckRules(int[] colRow)
        {
            int col1 = colRow[0];
            int row1 = colRow[1];
            int col2 = colRow[2];
            int row2 = colRow[3];

            Figure figure1 = board.place[col1, row1].Figure;
            Figure figure2 = board.place[col2, row2].Figure;

            if (figure1.side == blue)////////////rules for blue ones
            {
                if (figure1.symbol == pawn)///////////////pawn
                {
                    if (figure2 == null)
                    {
                        if (col2 == col1 && row2 == row1 - 1)
                        {
                            return true;
                        }
                    }
                    if (figure2.side == red)
                    {
                        if (col2 == col1 + 1 && row2 == row1 - 1 ||
                            col2 == col1 - 1 && row2 == row1 - 1)
                        {
                            return true;
                        }
                    }
                }
                if (figure1.symbol == rook) ////////rook
                {
                    if (figure2.side == red || figure2 == null)
                    {
                        if (col2 == col1 && row2 == row1 - 1)      // rules for forvard moove
                        {
                            return true;
                        }
                        if (col2 == col1 && row2 == row1 - 2)
                        {
                            if (board.place[col1, row1 - 1].Figure == null)
                            {
                                return true;
                            }
                        }
                        if (col2 == col1 && row2 == row1 - 3)
                        {
                            if (board.place[col1, row1 - 1].Figure == null &&
                                board.place[col1, row1 - 2].Figure == null)
                            {
                                return true;
                            }
                        }
                        if (col2 == col1 && row2 == row1 - 4)
                        {
                            if (board.place[col1, row1 - 1].Figure == null &&
                                board.place[col1, row1 - 2].Figure == null &&
                                board.place[col1, row1 - 3].Figure == null)
                            {
                                return true;
                            }
                        }
                        if (col2 == col1 && row2 == row1 - 5)
                        {
                            if (board.place[col1, row1 - 1].Figure == null &&
                                board.place[col1, row1 - 2].Figure == null &&
                                board.place[col1, row1 - 3].Figure == null &&
                                board.place[col1, row1 - 4].Figure == null)
                            {
                                return true;
                            }
                        }
                        if (col2 == col1 && row2 == row1 - 6)
                        {
                            if (board.place[col1, row1 - 1].Figure == null &&
                                board.place[col1, row1 - 2].Figure == null &&
                                board.place[col1, row1 - 3].Figure == null &&
                                board.place[col1, row1 - 4].Figure == null &&
                                board.place[col1, row1 - 5].Figure == null)
                            {
                                return true;
                            }
                        }
                        if (col2 == col1 && row2 == row1 - 7)
                        {
                            if (board.place[col1, row1 - 1].Figure == null &&
                                board.place[col1, row1 - 2].Figure == null &&
                                board.place[col1, row1 - 3].Figure == null &&
                                board.place[col1, row1 - 4].Figure == null &&
                                board.place[col1, row1 - 5].Figure == null &&
                                board.place[col1, row1 - 6].Figure == null)
                            {
                                return true;
                            }
                        }
                        if (col2 == col1 - 1 && row2 == row1)      // rules for left moove
                        {
                            return true;
                        }
                        if (col2 == col1 - 2 && row2 == row1)
                        {
                            if (board.place[col1 - 1, row1].Figure == null)
                            {
                                return true;
                            }
                        }
                        if (col2 == col1 - 3 && row2 == row1)
                        {
                            if (board.place[col1 - 1, row1].Figure == null &&
                                board.place[col1 - 2, row1].Figure == null)
                            {
                                return true;
                            }
                        }
                        if (col2 == col1 - 4 && row2 == row1)
                        {
                            if (board.place[col1 - 1, row1].Figure == null &&
                                board.place[col1 - 2, row1].Figure == null &&
                                board.place[col1 - 3, row1].Figure == null)
                            {
                                return true;
                            }
                        }
                        if (col2 == col1 - 5 && row2 == row1)
                        {
                            if (board.place[col1 - 1, row1].Figure == null &&
                                board.place[col1 - 2, row1].Figure == null &&
                                board.place[col1 - 3, row1].Figure == null &&
                                board.place[col1 - 4, row1].Figure == null)
                            {
                                return true;
                            }
                        }
                        if (col2 == col1 - 6 && row2 == row1)
                        {
                            if (board.place[col1 - 1, row1].Figure == null &&
                                board.place[col1 - 2, row1].Figure == null &&
                                board.place[col1 - 3, row1].Figure == null &&
                                board.place[col1 - 4, row1].Figure == null &&
                                board.place[col1 - 5, row1].Figure == null)
                            {
                                return true;
                            }
                        }
                        if (col2 == col1 - 7 && row2 == row1)
                        {
                            if (board.place[col1 - 1, row1].Figure == null &&
                                board.place[col1 - 2, row1].Figure == null &&
                                board.place[col1 - 3, row1].Figure == null &&
                                board.place[col1 - 4, row1].Figure == null &&
                                board.place[col1 - 5, row1].Figure == null &&
                                board.place[col1 - 6, row1].Figure == null)
                            {
                                return true;
                            }
                        }
                        if (col2 == col1 + 1 && row2 == row1)      // rules for right moove
                        {
                            return true;
                        }
                        if (col2 == col1 + 2 && row2 == row1)
                        {
                            if (board.place[col1 + 1, row1].Figure == null)
                            {
                                return true;
                            }
                        }
                        if (col2 == col1 + 3 && row2 == row1)
                        {
                            if (board.place[col1 + 1, row1].Figure == null &&
                                board.place[col1 + 2, row1].Figure == null)
                            {
                                return true;
                            }
                        }
                        if (col2 == col1 + 4 && row2 == row1)
                        {
                            if (board.place[col1 + 1, row1].Figure == null &&
                                board.place[col1 + 2, row1].Figure == null &&
                                board.place[col1 + 3, row1].Figure == null)
                            {
                                return true;
                            }
                        }
                        if (col2 == col1 + 5 && row2 == row1)
                        {
                            if (board.place[col1 + 1, row1].Figure == null &&
                                board.place[col1 + 2, row1].Figure == null &&
                                board.place[col1 + 3, row1].Figure == null &&
                                board.place[col1 + 4, row1].Figure == null)
                            {
                                return true;
                            }
                        }
                        if (col2 == col1 + 6 && row2 == row1)
                        {
                            if (board.place[col1 + 1, row1].Figure == null &&
                                board.place[col1 + 2, row1].Figure == null &&
                                board.place[col1 + 3, row1].Figure == null &&
                                board.place[col1 + 4, row1].Figure == null &&
                                board.place[col1 + 5, row1].Figure == null)
                            {
                                return true;
                            }
                        }
                        if (col2 == col1 + 7 && row2 == row1)
                        {
                            if (board.place[col1 + 1, row1].Figure == null &&
                                board.place[col1 + 2, row1].Figure == null &&
                                board.place[col1 + 3, row1].Figure == null &&
                                board.place[col1 + 4, row1].Figure == null &&
                                board.place[col1 + 5, row1].Figure == null &&
                                board.place[col1 + 6, row1].Figure == null)
                            {
                                return true;
                            }
                        }
                        if (col2 == col1 && row2 == row1 + 1)      // rules for back moove
                        {
                            return true;
                        }
                        if (col2 == col1 && row2 == row1 + 2)
                        {
                            if (board.place[col1, row1 + 1].Figure == null)
                            {
                                return true;
                            }
                        }
                        if (col2 == col1 && row2 == row1 + 3)
                        {
                            if (board.place[col1, row1 + 1].Figure == null &&
                                board.place[col1, row1 + 2].Figure == null)
                            {
                                return true;
                            }
                        }
                        if (col2 == col1 && row2 == row1 + 4)
                        {
                            if (board.place[col1, row1 + 1].Figure == null &&
                                board.place[col1, row1 + 2].Figure == null &&
                                board.place[col1, row1 + 3].Figure == null)
                            {
                                return true;
                            }
                        }
                        if (col2 == col1 && row2 == row1 + 5)
                        {
                            if (board.place[col1, row1 + 1].Figure == null &&
                                board.place[col1, row1 + 2].Figure == null &&
                                board.place[col1, row1 + 3].Figure == null &&
                                board.place[col1, row1 + 4].Figure == null)
                            {
                                return true;
                            }
                        }
                        if (col2 == col1 && row2 == row1 + 6)
                        {
                            if (board.place[col1, row1 + 1].Figure == null &&
                                board.place[col1, row1 + 2].Figure == null &&
                                board.place[col1, row1 + 3].Figure == null &&
                                board.place[col1, row1 + 4].Figure == null &&
                                board.place[col1, row1 + 5].Figure == null)
                            {
                                return true;
                            }
                        }
                        if (col2 == col1 && row2 == row1 + 7)
                        {
                            if (board.place[col1, row1 + 1].Figure == null &&
                                board.place[col1, row1 + 2].Figure == null &&
                                board.place[col1, row1 + 3].Figure == null &&
                                board.place[col1, row1 + 4].Figure == null &&
                                board.place[col1, row1 + 5].Figure == null &&
                                board.place[col1, row1 + 6].Figure == null)
                            {
                                return true;
                            }
                        }
                    }
                }





















                if (figure1.symbol == knight) //////////knight
                {
                    if (figure2 == null || figure2.side == red)
                    {
                        if (col2 == col1 + 2 && row2 == row1 - 1)
                        {
                            return true;
                        }
                        if (col2 == col1 + 1 && row2 == row1 - 2)
                        {
                            return true;
                        }
                        if (col2 == col1 - 1 && row2 == row1 - 2)
                        {
                            return true;
                        }
                        if (col2 == col1 - 2 && row2 == row1 - 1)
                        {
                            return true;
                        }
                        if (col2 == col1 - 2 && row2 == row1 + 1)
                        {
                            return true;
                        }
                        if (col2 == col1 - 1 && row2 == row1 + 2)
                        {
                            return true;
                        }
                        if (col2 == col1 + 1 && row2 == row1 + 2)
                        {
                            return true;
                        }
                        if (col2 == col1 + 2 && row2 == row1 + 1)
                        {
                            return true;
                        }
                    }
                }
                if (figure1.symbol == bishop) /////////// bishop
                {
                    if (figure2 == null)
                    {

                    }
                    if (figure2.side == red)
                    {

                    }
                }
                if (figure1.symbol == queen) //////////////queen
                {
                    if (figure2 == null)
                    {

                    }
                    if (figure2.side == red)
                    {

                    }
                }
                if (figure1.symbol == king)/////////////king
                {
                    if (figure2 == null)
                    {

                    }
                    if (figure2.side == red)
                    {

                    }
                }
            }
            Console.WriteLine("                               !!!!!!!!!!!!!! WARNING !!!!!!!!!!!!!!!");
            Console.WriteLine("                               !!!!!!!!!!!!!! WARNING !!!!!!!!!!!!!!!");
            Console.WriteLine("                               !!!!!!!!!!!!!! WARNING !!!!!!!!!!!!!!!");
            Console.WriteLine("                               !!!!!!!!!!!!!! WARNING !!!!!!!!!!!!!!!");
            Console.ReadKey();
            return false;
        }
    }
}


