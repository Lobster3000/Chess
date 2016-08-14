
using System;
using System.Collections.Generic;

namespace Chess
{
    class Program
    {

        static void Main()
        {
            Console.BufferHeight = Console.WindowHeight = 50;
            Console.BufferWidth = Console.WindowWidth = 40;
            Console.WriteLine("Let the game begin");

            Board board = new Board();
            Swaper swaper = new Swaper(board);
            Asker asker = new Asker();
            Judge judge = new Judge(board); 
            EnemyAI enemyAI = new EnemyAI();
            int[] choise;
            bool IsEnemyTurn = true;

            //game cicle
            while (true)
            {
                while (true)
                {
                    board.Show();
                    Console.WriteLine("you play as blue");
                    //////player move
                    choise = asker.Choose();
                    if (judge.CheckRules(choise))
                    {
                        //win condition
                        if (board.place[choise[2], choise[3]].Figure != null)
                        {
                            if (board.place[choise[2], choise[3]].Figure.symbol == "6")
                            {
                                swaper.Swap(choise);
                                Console.Clear();
                                board.Show();
                                for (int i = 0; i < 10; i++)
                                {
                                    Console.WriteLine("YOU WIN");
                                }
                                Console.WriteLine("PRESS ENY KEY TO RESET THE GAME");
                                Console.ReadKey();
                                board.resetBoard();
                                IsEnemyTurn = false;
                                break;
                            }
                        }
                        IsEnemyTurn = true;
                        swaper.Swap(choise);
                        break;
                    }
                    else
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            Console.WriteLine("!!!!!!!!!!!!!!!!!!!  AGAINST THE RULE  !!!!!!!!!!!!!!!!!!!!!!!");
                        }
                    }
                }

                /////// AI move
                while (IsEnemyTurn)
                {
                    //condition of enemy win
                    choise = enemyAI.Choise();
                    if (judge.CheckRulesEnemy(choise))
                    {
                        if (board.place[choise[2], choise[3]].Figure != null)
                        {
                            if (board.place[choise[2], choise[3]].Figure.symbol == "6")
                            {
                                swaper.Swap(choise);
                                Console.Clear();
                                board.Show();
                                for (int i = 0; i < 10; i++)
                                {
                                    Console.WriteLine("YOU LOOSE");
                                }
                                Console.WriteLine("PRESS ENY KEY TO RESET THE GAME");
                                Console.ReadKey();
                                board.resetBoard();
                                break;
                            }
                        }
                        swaper.Swap(choise);
                        break;
                    }
                }
                Console.Clear();
            }
        }
    }
}












