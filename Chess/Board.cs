using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Board
    {
        const int boardSize = 8;
        public bool blue = true;
        public bool red = false;
        public Place[,] place = new Place[boardSize, boardSize];

        public Board()
        {
            bool isWhite = true;
            for (int i = 0; i < boardSize - 1; i = i + 2)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    place[j, i] = new Place(isWhite);
                    isWhite = !isWhite;
                }
            }
            isWhite = false;
            for (int i = 1; i < boardSize ; i = i + 2)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    place[j, i] = new Place(isWhite);
                    isWhite = !isWhite;
                }
            }
            //board places
            place[0, 0].Figure = new Rook  (red);      place[0, 1].Figure = new Pawn(red);     place[0, 6].Figure = new Pawn(blue);    place[0, 7].Figure = new Rook(blue);
            place[1, 0].Figure = new Knight(red);    place[1, 1].Figure = new Pawn(red);     place[1, 6].Figure = new Pawn(blue);    place[1, 7].Figure = new Knight(blue);
            place[2, 0].Figure = new Bishop(red);    place[2, 1].Figure = new Pawn(red);     place[2, 6].Figure = new Pawn(blue);    place[2, 7].Figure = new Bishop(blue);
            place[3, 0].Figure = new Queen (red);     place[3, 1].Figure = new Pawn(red);     place[3, 6].Figure = new Pawn(blue);    place[3, 7].Figure = new Queen(blue); 
            place[4, 0].Figure = new King  (red);      place[4, 1].Figure = new Pawn(red);     place[4, 6].Figure = new Pawn(blue);    place[4, 7].Figure = new King(blue);  
            place[5, 0].Figure = new Bishop(red);    place[5, 1].Figure = new Pawn(red);     place[5, 6].Figure = new Pawn(blue);    place[5, 7].Figure = new Bishop(blue);
            place[6, 0].Figure = new Knight(red);    place[6, 1].Figure = new Pawn(red);     place[6, 6].Figure = new Pawn(blue);    place[6, 7].Figure = new Knight(blue);
            place[7, 0].Figure = new Rook  (red);      place[7, 1].Figure = new Pawn(red);     place[7, 6].Figure = new Pawn(blue);    place[7, 7].Figure = new Rook(blue);  
        }

        /*public void white()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write(" ");
            Console.ResetColor();
        }
        */
        public void Show()
        {
            Console.WriteLine();
            Console.WriteLine("     A   B   C   D   E   F   G   H");
            for (int i = 0; i < boardSize; i++)
            {
                Console.WriteLine("   ---------------------------------");
                Console.Write(i + 1+" ");
                for (int j = 0; j < boardSize; j++)
                {
                    Console.Write(" | ");
                    Console.Write(place[j, i]);
                    Console.ResetColor();
                }
                Console.Write(" |  ");
                Console.WriteLine(i + 1);
            }
            Console.WriteLine("   ---------------------------------");
            Console.WriteLine("     A   B   C   D   E   F   G   H");
            Console.WriteLine();

        }
    }
}
