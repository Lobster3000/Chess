using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Program
    {
        const int boardSize = 8;
        Place[,] place = new Place[8, 8];
        static void Main()
        {
            PrintingDesk();
            Console.ReadKey();
        }
        static void Choose()
        {
        }
        static void CreatePlaces()
        {
        }
        static void PrintingDesk()
        {
            for (int row = 0; row < boardSize; row++)
            {
                Console.Write("----");
                for (int x = 0; x < boardSize; x++)
                {
                    Console.Write("|");
                    for (int col = 0; col < boardSize; col++)
                    {
                        place[row, col].Draw(x);
                    }
                    Console.WriteLine("|");
                }
                Console.Write(" ");
                Console.Write(" ");
                Console.WriteLine();
            }
        }
    }
}

/*
for (int row = 0; row<boardSize; row++)
            {
                Console.Write("----");
                for (int x = 0; x<boardSize; x++)
                {
                    Console.Write("|");
                    for (int col = 0; col<boardSize; col++)
                    { 
                        //place[row, col].Draw(x);
                    }
                    Console.WriteLine("|");
                }
                Console.Write(" ");
                Console.Write(" ");
                Console.WriteLine();
            }
            */
            