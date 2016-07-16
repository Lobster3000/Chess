using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Figure
    {
        public string symbol;
        public bool side;
        protected bool blue = true;
        protected bool red = false;

        public override string ToString()
        {
            if (side == blue)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            } 
            if (side == red)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            return symbol;
        }
    }
}
