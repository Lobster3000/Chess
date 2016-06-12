using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Program
    {
        static Place[,] place = new Place[8, 8];
        static void Main()
        {
            CreatePlaces();
            int a = 1;
            while (a == 1)
            {
                PrintingDesk();
                Choose();
            }
            Console.ReadKey();
        }
        static void Choose()
        {
            //choosing figure
            Console.WriteLine("Choose leter1");
            string leter = Console.ReadLine();
            int leter1 = 0;
            if (leter == "a" || leter == "A") { leter1 = 0; }
            if (leter == "b" || leter == "B") { leter1 = 1; }
            if (leter == "c" || leter == "C") { leter1 = 2; }
            if (leter == "d" || leter == "D") { leter1 = 3; }
            if (leter == "e" || leter == "E") { leter1 = 4; }
            if (leter == "f" || leter == "F") { leter1 = 5; }
            if (leter == "g" || leter == "G") { leter1 = 6; }
            if (leter == "h" || leter == "H") { leter1 = 7; }
            Console.WriteLine("Choose number1");
            int column1 = Convert.ToInt32(Console.ReadLine()) - 1;
            //choosing destanation
            Console.WriteLine("Choose leter2");
            leter = Console.ReadLine();
            int leter2 = 0;
            if (leter == "a" || leter == "A") { leter2 = 0; }
            if (leter == "b" || leter == "B") { leter2 = 1; }
            if (leter == "c" || leter == "C") { leter2 = 2; }
            if (leter == "d" || leter == "D") { leter2 = 3; }
            if (leter == "e" || leter == "E") { leter2 = 4; }
            if (leter == "f" || leter == "F") { leter2 = 5; }
            if (leter == "g" || leter == "G") { leter2 = 6; }
            if (leter == "h" || leter == "H") { leter2 = 7; }
            Console.WriteLine("Choose number2");
            int column2 = Convert.ToInt32(Console.ReadLine()) - 1;
            //string a = place[leter1, column1];
            //rules cheking------------------------------------------------------
            //-------------------------------------------------------------------
            
        }
        static void CreatePlaces()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    place[j, i] = new Place();
                }
            }

            //for (int i = 0; i < 8; i++)
            //{
            //    place[2, i].AddFigure(new Pawn());
            //    place[7, i].AddFigure(new Pawn());
            //}

            //place[0, 7] = "2"; place[0, 6] = "1"; place[0, 1] = "1"; place[0, 0] = "2";    _
            //place[1, 7] = "3"; place[1, 6] = "1"; place[1, 1] = "1"; place[1, 0] = "3";
            //place[2, 7] = "4"; place[2, 6] = "1"; place[2, 1] = "1"; place[2, 0] = "4";
            //place[3, 7] = "6"; place[3, 6] = "1"; place[3, 1] = "1"; place[3, 0] = "6";
            //place[4, 7] = "5"; place[4, 6] = "1"; place[4, 1] = "1"; place[4, 0] = "5";
            //place[5, 7] = "4"; place[5, 6] = "1"; place[5, 1] = "1"; place[5, 0] = "4";
            //place[6, 7] = "3"; place[6, 6] = "1"; place[6, 1] = "1"; place[6, 0] = "3";
            //place[7, 7] = "2"; place[7, 6] = "1"; place[7, 1] = "1"; place[7, 0] = "2";
        }
        static void PrintingDesk()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("    A B C D E F G H");
            Console.WriteLine();


            for (int row = 0; row < 8; row++)
            {
                
                for (int x = 1; x <= Place.SizeLines; x++)
                {
                    Console.Write("|");
                    for (int col = 0; col < 8; col++)
                    { 
                        place[row, col].Draw(x);
                    }
                    Console.WriteLine("|");
                }

                
                //Console.Write(" ");
                
                //Console.Write("  " + i);
                //Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("    A B C D E F G H");
            Console.WriteLine("----------------------------------------");
        }
    }
}