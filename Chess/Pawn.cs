using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Pawn : Figure
    {
        public Pawn(bool a)
        {
            symbol = "1";
            side = a;
        }
    }
}
