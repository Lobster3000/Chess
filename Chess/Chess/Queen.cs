﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Queen : Figure
    {
        public Queen(bool isBlack) : base(isBlack)
        {
            symbol = "5";
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

                for (int i = 2; i < 8; i++) //forward
                {
                    if (toCol == fromCol && toRow == fromRow - i)
                    {
                        int count = 0;
                        for (int j = 1; j < i; j++)
                        {
                            if (board.place[fromCol, fromRow - j].Figure == null)
                            {
                                count++;
                                if (count == i - 1)
                                {

                                    return true;
                                }
                            }
                        }
                    }
                }

                for (int i = 2; i < 8; i++) //left
                {
                    if (toCol == fromCol - i && toRow == fromRow)
                    {
                        int count = 0;
                        for (int j = 1; j < i; j++)
                        {
                            if (board.place[fromCol - j, fromRow].Figure == null)
                            {
                                count++;
                                if (count == i - 1)
                                {

                                    return true;
                                }
                            }
                        }
                    }
                }

                for (int i = 2; i < 8; i++) //down
                {
                    if (toCol == fromCol && toRow == fromRow + i)
                    {
                        int count = 0;
                        for (int j = 1; j < i; j++)
                        {
                            if (board.place[fromCol, fromRow + j].Figure == null)
                            {
                                count++;
                                if (count == i - 1)
                                {

                                    return true;
                                }
                            }
                        }
                    }
                }

                for (int i = 2; i < 8; i++) //right
                {
                    if (toCol == fromCol + i && toRow == fromRow)
                    {
                        int count = 0;
                        for (int j = 1; j < i; j++)
                        {
                            if (board.place[fromCol + j, fromRow].Figure == null)
                            {
                                count++;
                                if (count == i - 1)
                                {
                                    return true;
                                }
                            }
                        }
                    }
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

                for (int i = 2; i < 8; i++) //north west
                {
                    if (toCol == fromCol - i && toRow == fromRow - i)
                    {
                        int count = 0;
                        for (int j = 1; j < i; j++)
                        {
                            if (board.place[fromCol - j, fromRow - j].Figure == null)
                            {
                                count++;
                                if (count == i - 1)
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }

                for (int i = 2; i < 8; i++)// west south
                {
                    if (toCol == fromCol + i && toRow == fromRow - i)
                    {
                        int count = 0;
                        for (int j = 1; j < i; j++)
                        {
                            if (board.place[fromCol + j, fromRow - j].Figure == null)
                            {
                                count++;
                                if (count == i - 1)
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }

                for (int i = 2; i < 8; i++)       //south east
                {
                    if (toCol == fromCol - i && toRow == fromRow + i)
                    {
                        int count = 0;
                        for (int j = 1; j < i; j++)
                        {
                            if (board.place[fromCol - j, fromRow + j].Figure == null)
                            {
                                count++;
                                if (count == i - 1)
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }

                for (int i = 2; i < 8; i++)  //north east
                {
                    if (toCol == fromCol + i && toRow == fromRow + i)
                    {
                        int count = 0;
                        for (int j = 1; j < i; j++)
                        {
                            if (board.place[fromCol + j, fromRow + j].Figure == null)
                            {
                                count++;
                                if (count == i - 1)
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }
    }
}