using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Swaper
    {
        private Board m_Board;

        public Swaper(Board b)
        {
            m_Board = b;
        }

        public void Swap(int[] arr)
        {
            m_Board.place[arr[2], arr[3]].Figure = m_Board.place[arr[0], arr[1]].Figure;
            m_Board.place[arr[0], arr[1]].Figure = null;
        }
    }
}
