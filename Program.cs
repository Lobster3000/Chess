using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication21
{
    class Program
    {
        static void Main(string[] args)
        {
            CreatePlaces();
            //PrintingDesk();
            Console.ReadKey();
        }
        static void CreatePlaces()
        {
            string[,] place = new string[8, 8];
            for (int i = 0; i<8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    place[j, i] = "0";
                }
            }
            place[0, 0] = "2";   place[1, 0] = "2";    place[6, 0] = "2";      place[7, 0] = "2";
            place[0, 1] = "3";   place[1, 1] = "3";    place[6, 1] = "3";      place[7, 1] = "3";
            place[0, 2] = "4";   place[1, 2] = "4";    place[6, 2] = "4";      place[7, 2] = "4";
            place[0, 3] = "6";   place[1, 3] = "6";    place[6, 3] = "6";      place[7, 3] = "6";
            place[0, 4] = "5";   place[1, 4] = "5";    place[6, 4] = "5";      place[7, 4] = "5";
            place[0, 5] = "4";   place[1, 5] = "4";    place[6, 5] = "4";      place[7, 5] = "4";
            place[0, 6] = "3";   place[1, 6] = "3";    place[6, 6] = "3";      place[7, 6] = "3";
            place[0, 7] = "2";   place[1, 7] = "2";    place[6, 7] = "2";      place[7, 7] = "2";

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.WriteLine(place[j, i]);
                }
            }
        }
        static void PrintingDesk()
        {
            string[,] place = new string[8, 8];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.WriteLine(place[j, i]);
                }
            }
            
            //Console.WriteLine("2 1 0 0 0 0 1 2");
            //Console.WriteLine("3 1 0 0 0 0 1 3");
            //Console.WriteLine("4 1 0 0 0 0 1 4");
            //Console.WriteLine("6 1 0 0 0 0 1 6");
            //Console.WriteLine("5 1 0 0 0 0 1 5");
            //Console.WriteLine("4 1 0 0 0 0 1 4");
            //Console.WriteLine("3 1 0 0 0 0 1 3");
            //Console.WriteLine("2 1 0 0 0 0 1 2");
        }
    }
}
