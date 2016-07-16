
using System;
using System.Collections.Generic;

namespace Chess
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Let the game begin");

            Board board = new Board();
            Swaper swaper = new Swaper(board);
            Asker asker = new Asker();
            Judge judge = new Judge(board); 

            while (true)
            {
                board.Show();
                int[] choise = asker.Choose();
                if (judge.CheckRules(choise))
                {
                    swaper.Swap(choise);
                }
                Console.Clear();
            }
        }
    }
}












