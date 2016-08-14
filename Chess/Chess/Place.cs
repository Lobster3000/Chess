using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Place
    {
        bool m_IsWhite = false;

        Figure m_Figure;
        public Place(bool isWhite)
        {
            m_IsWhite = isWhite;
            m_Figure = null;
        }

        public Figure Figure
        {
            get { return m_Figure; }
            set { m_Figure = value; }
        }

        public override string ToString()
        {
            if (m_IsWhite) {
                Console.BackgroundColor = ConsoleColor.White;
            } else {
                Console.BackgroundColor = ConsoleColor.Black;
            }

            if (m_Figure != null)
            {
                return m_Figure.ToString();
            } else {
                return " ";
            }
        }
    }
}
