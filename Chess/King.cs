using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class King : Figure
    {
        public King(bool a)
        {
            symbol = "6";
            side = a;
        }
    }
}
