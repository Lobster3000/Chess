using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    abstract class Figure
    {
        public string symbol;
        
        protected bool m_IsBlack;
        public bool IsBlack
        {
            get { return m_IsBlack; }
        }
        
        public Figure(bool isBlack) 
        {
            m_IsBlack = isBlack;
        }

        public abstract bool IsValidMove(int fromCol, int fromRow, int toCol, int toRow, Board board);

        public override string ToString()
        {
            if (m_IsBlack)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            } 
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            return symbol;
        }
    }
}
