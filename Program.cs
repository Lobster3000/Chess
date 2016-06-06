using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication21
{

    class Program
    {
        static string[,] place = new string[8, 8];












        static void Main()
        {
            CreatePlaces();
            PrintingDesk();
            Choose();
            PrintingDesk();
            Console.ReadKey();
        }
        static void Choose()
        {
            //choosing figure
            Console.WriteLine("Choosing figure place");
            Console.WriteLine("Choose line");
            int line1  = Convert.ToInt32(Console.ReadLine()) -1 ;   
            Console.WriteLine("Choose column");
            int column1 = Convert.ToInt32(Console.ReadLine()) - 1;
            //choosing destanation
            Console.WriteLine("Choosing figure place");
            Console.WriteLine("Choose line");
            int line2 = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.WriteLine("Choose column");
            int column2 = Convert.ToInt32(Console.ReadLine()) - 1;
            string a = place[line1, column1];
            string b = place[line2, column2];
            place[line1, column1] = b;
            place[line2, column2] = a;
        }
        static void CreatePlaces()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    place[j, i] = "0";
                }
            }
            place[0, 0] = "2"; place[1, 0] = "1"; place[6, 0] = "1"; place[7, 0] = "2";
            place[0, 1] = "3"; place[1, 1] = "1"; place[6, 1] = "1"; place[7, 1] = "3";
            place[0, 2] = "4"; place[1, 2] = "1"; place[6, 2] = "1"; place[7, 2] = "4";
            place[0, 3] = "6"; place[1, 3] = "1"; place[6, 3] = "1"; place[7, 3] = "6";
            place[0, 4] = "5"; place[1, 4] = "1"; place[6, 4] = "1"; place[7, 4] = "5";
            place[0, 5] = "4"; place[1, 5] = "1"; place[6, 5] = "1"; place[7, 5] = "4";
            place[0, 6] = "3"; place[1, 6] = "1"; place[6, 6] = "1"; place[7, 6] = "3";
            place[0, 7] = "2"; place[1, 7] = "1"; place[6, 7] = "1"; place[7, 7] = "2";
        }
        static void PrintingDesk()
        {
            Console.WriteLine("Desk");
            Console.WriteLine("----------------------------------------");
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(place[j, i]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------------------");
        }
    }
}
