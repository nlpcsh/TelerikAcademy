namespace MineSweeperGame
{
    using System;
    using System.Collections.Generic;

    internal static class Output
    {
        internal static void PrintHello()
        {
            Console.WriteLine("Hello fearless player! Lets sweep some mines!");
            Console.WriteLine(" Game menu: ");
            Console.WriteLine(" top     -> shows the score board ");
            Console.WriteLine(" restart -> reset the game");
            Console.WriteLine(" exit    -> to quit the game");
        }

        internal static void PrintLine(string toPrint)
        {
            Console.WriteLine(toPrint);
        }

        internal static void PrintLine(string toPrint, int number)
        {
            Console.WriteLine(toPrint, number);
        }

        internal static void Print(string toPrint)
        {
            Console.Write(toPrint);
        }

        internal static void PrintScore(List<Score> scoreList)
        {
            Console.WriteLine("\n Score List:");

            if (scoreList.Count > 0)
            {
                for (int i = 0; i < scoreList.Count; i++)
                {
                    Console.WriteLine(" {0}. {1} --> {2} points", i + 1, scoreList[i].Name, scoreList[i].PlayerScore);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No score yet!\n");
            }
        }

        internal static void PrintBoard(char[,] board)
        {
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");

            for (int i = 0; i < Game.Rows; i++)
            {
                Console.Write("{0} | ", i);

                for (int j = 0; j < Game.Cols; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }
    }
}
