using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class EnemyAI
    {
        Random random = new Random();

        public int[] Choise()
        {
            int[] colRow = new int[4];
            for (int i = 0; i < 4; i++)
            {
                colRow[i] = random.Next(0, 8);
            }
            return colRow;
        }

    }
}
