using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Place
    {
        private Figure figure;

        //private column, row;
        //private top, bottom, left, right; 

        public static int SizeLines = 5;

        public bool IsEmpty()
        {
            return figure == null;
        }

        public void Draw(int line)
        {
            switch (line)
            {
                case 1:
                case 5:
                    Console.Write("------");
                    break;
                case 2:
                case 3:
                case 4:
                    Console.Write("|    |");
                    break;
                //case 3:
                //    if (this.IsEmpty())
                //    {
                //        Console.Write("# ");
                //        figure.Draw();
                //        Console.Write(" #");
                //    } else {
                //        Console.Write("#    #");
                //    }
                //    break;
            }
        }
    }
}
