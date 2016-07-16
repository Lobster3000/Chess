using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Queen : Figure
    {
        public Queen(bool a)
        {
            symbol = "5";
            side = a;
        }
    }
}
