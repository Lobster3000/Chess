using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Asker
    {

        int leter1 = 0;
        int number1 = 0;
        int leter2 = 0;
        int number2 = 0;
        bool box1 = false;
        public int[] Choose()
        {
            //coosing figure
            Console.WriteLine("Choose figure to moove");

            while (box1 == false)
            {
                Console.Write("Leter1:");
                string choise1 = Console.ReadLine();
                if (choise1 == "a" || choise1 == "A") { leter1 = 0; box1 = true; }
                else if (choise1 == "b" || choise1 == "B") { leter1 = 1; box1 = true; }
                else if (choise1 == "c" || choise1 == "C") { leter1 = 2; box1 = true; }
                else if (choise1 == "d" || choise1 == "D") { leter1 = 3; box1 = true; }
                else if (choise1 == "e" || choise1 == "E") { leter1 = 4; box1 = true; }
                else if (choise1 == "f" || choise1 == "F") { leter1 = 5; box1 = true; }
                else if (choise1 == "g" || choise1 == "G") { leter1 = 6; box1 = true; }
                else if (choise1 == "h" || choise1 == "H") { leter1 = 7; box1 = true; }
                else { Console.WriteLine("Wrong input, enter again"); box1 = false; }
            }
            box1 = false;

            while (box1 == false)
            {
                Console.Write("Number1:");
                number1 = Convert.ToInt32(Console.ReadLine()) - 1;
                if (number1 >= 0 || number1 <= 7)
                {
                    box1 = true;
                } 
                else
                {
                    Console.WriteLine("Wrong input, enter again");
                    box1 = false;
                }
            }
            box1 = false;
            

            while (box1 == false)
            {
                Console.Write("Leter2:");
                string choise1 = Console.ReadLine();
                if (choise1 == "a" || choise1 == "A") { leter2 = 0; box1 = true; }
                else if (choise1 == "b" || choise1 == "B") { leter2 = 1; box1 = true; }
                else if (choise1 == "c" || choise1 == "C") { leter2 = 2; box1 = true; }
                else if (choise1 == "d" || choise1 == "D") { leter2 = 3; box1 = true; }
                else if (choise1 == "e" || choise1 == "E") { leter2 = 4; box1 = true; }
                else if (choise1 == "f" || choise1 == "F") { leter2 = 5; box1 = true; }
                else if (choise1 == "g" || choise1 == "G") { leter2 = 6; box1 = true; }
                else if (choise1 == "h" || choise1 == "H") { leter2 = 7; box1 = true; }
                else { Console.WriteLine("Wrong input, enter again"); box1 = false; }
            }
            box1 = false;

            while (box1 == false)
            {
                Console.Write("Number2:");
                number2 = Convert.ToInt32(Console.ReadLine()) - 1;
                if (number2 >= 0 || number2 <= 7)
                {
                    box1 = true;
                }
                else
                {
                    Console.WriteLine("Wrong input, enter again");
                    box1 = false;
                }
            }
            box1 = false;
            
            int[] box = new int[4];
            box[0] = leter1;
            box[1] = number1;
            box[2] = leter2;
            box[3] = number2;
            return box;

        }
    }
}
