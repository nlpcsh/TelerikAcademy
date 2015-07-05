namespace MineSweeperGame
{
    using System;
    using System.Collections.Generic;

    public class MineSweeper
    {
        private static List<Score> playersSoreList = new List<Score>(6);

        internal static void Main(string[] arguments)
        {
            string input = string.Empty;
            string result = string.Empty;

            Game currentGame = new Game();
            Output.PrintHello();

            do
            {
                Output.PrintBoard(currentGame.Field);

                Output.PrintLine("Enter new 'ROW' and 'COL': ");
                input = Console.ReadLine();

                input = Input.Validate(input, currentGame);

                switch (input)
                {
                    case "top":
                        Output.PrintScore(playersSoreList);
                        break;
                    case "restart":
                        currentGame = new Game();
                        Output.PrintBoard(currentGame.Field);
                        break;
                    case "exit":
                        break;
                    case "turn":
                        result = currentGame.MakeTurn();
                        break;
                    default:
                        Output.PrintLine("\n Input Error!\n");
                        break;
                }

                if (result == "finish")
                {
                    // Game over because of reveling all of the board
                    currentGame = RevealedAllMines(playersSoreList, currentGame);
                }
                else if (result == "mine")
                {
                    // Game over because of mine blowing
                    MineBlowed(currentGame);
                    currentGame = new Game();
                }
            }
            while (input != "exit");

            Console.WriteLine("Good Bye!");
            Console.Read();
        }

        private static Game RevealedAllMines(List<Score> playersSoreList, Game currentGame)
        {
            Output.PrintLine("\n You cross the minefield! ");
            Output.PrintBoard(currentGame.MinesPositions);
            Output.PrintLine("\n Put your name in the heroes list: ");
            string playersName = Console.ReadLine();
            Score currentPoints = new Score(playersName, currentGame.ScoreCounter);
            playersSoreList.Add(currentPoints);
            Output.PrintScore(playersSoreList);

            currentGame = new Game();

            return currentGame;
        }

        private static void MineBlowed(Game currentGame)
        {
            Output.PrintBoard(currentGame.MinesPositions);
            Output.PrintLine("\n Game Over! You gain {0} points. Enter your name: ", currentGame.ScoreCounter);

            string playersName = Console.ReadLine();

            Score currentScore = new Score(playersName, currentGame.ScoreCounter);

            if (playersSoreList.Count < 5)
            {
                playersSoreList.Add(currentScore);
            }
            else
            {
                for (int i = 0; i < playersSoreList.Count; i++)
                {
                    if (playersSoreList[i].PlayerScore < currentScore.PlayerScore)
                    {
                        playersSoreList.Insert(i, currentScore);
                        playersSoreList.RemoveAt(playersSoreList.Count - 1);
                        break;
                    }
                }
            }

            playersSoreList.Sort((Score player1, Score player2) => player2.Name.CompareTo(player1.Name));
            playersSoreList.Sort((Score player1, Score player2) => player2.PlayerScore.CompareTo(player1.PlayerScore));
            
            Output.PrintScore(playersSoreList);
        }
    }
}
