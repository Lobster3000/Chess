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
        public int[] Choose()
        {
            //coosing figure
            Console.WriteLine("Choose figure to moove");
            while (true)
            {
                Console.Write("Leter1:");
                string choise1 = Console.ReadLine();
                /* */if (choise1 == "a" || choise1 == "A") { leter1 = 0; break; }
                else if (choise1 == "b" || choise1 == "B") { leter1 = 1; break; }
                else if (choise1 == "c" || choise1 == "C") { leter1 = 2; break; }
                else if (choise1 == "d" || choise1 == "D") { leter1 = 3; break; }
                else if (choise1 == "e" || choise1 == "E") { leter1 = 4; break; }
                else if (choise1 == "f" || choise1 == "F") { leter1 = 5; break; }
                else if (choise1 == "g" || choise1 == "G") { leter1 = 6; break; }
                else if (choise1 == "h" || choise1 == "H") { leter1 = 7; break; }
                else { Console.WriteLine("Wrong input, enter again"); }
            }
            while (true)
            {
                Console.Write("Number1:");
                string choise1 = Console.ReadLine();
                /* */if (choise1 == "1") { number1 = 0; break; }
                else if (choise1 == "2") { number1 = 1; break; }
                else if (choise1 == "3") { number1 = 2; break; }
                else if (choise1 == "4") { number1 = 3; break; }
                else if (choise1 == "5") { number1 = 4; break; }
                else if (choise1 == "6") { number1 = 5; break; }
                else if (choise1 == "7") { number1 = 6; break; }
                else if (choise1 == "8") { number1 = 7; break; }
                else { Console.WriteLine("Wrong input, enter again"); }
            }
            while (true)
            {
                Console.Write("Leter2:");
                string choise1 = Console.ReadLine();
                /* */if (choise1 == "a" || choise1 == "A") { leter2 = 0; break; }
                else if (choise1 == "b" || choise1 == "B") { leter2 = 1; break; }
                else if (choise1 == "c" || choise1 == "C") { leter2 = 2; break; }
                else if (choise1 == "d" || choise1 == "D") { leter2 = 3; break; }
                else if (choise1 == "e" || choise1 == "E") { leter2 = 4; break; }
                else if (choise1 == "f" || choise1 == "F") { leter2 = 5; break; }
                else if (choise1 == "g" || choise1 == "G") { leter2 = 6; break; }
                else if (choise1 == "h" || choise1 == "H") { leter2 = 7; break; }
                else { Console.WriteLine("Wrong input, enter again"); }
            }
            while (true)
            {
                Console.Write("Number2:");
                string choise1 = Console.ReadLine();
                /* */if (choise1 == "1") { number2 = 0; break; }
                else if (choise1 == "2") { number2 = 1; break; }
                else if (choise1 == "3") { number2 = 2; break; }
                else if (choise1 == "4") { number2 = 3; break; }
                else if (choise1 == "5") { number2 = 4; break; }
                else if (choise1 == "6") { number2 = 5; break; }
                else if (choise1 == "7") { number2 = 6; break; }
                else if (choise1 == "8") { number2 = 7; break; }
                else { Console.WriteLine("Wrong input, enter again"); }
            }

            int[] box = new int[4];
            box[0] = leter1;
            box[1] = number1;
            box[2] = leter2;
            box[3] = number2;
            return box;

        }
    }
}
