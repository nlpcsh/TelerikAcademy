namespace MineSweeperGame
{
    using System;

    internal static class Input
    {
        internal static string Validate(string input, Game currentGame)
        {
            string validatedString = input.Trim();

            if (input.Length >= 3)
            {
                int row, col;
                bool validRow = int.TryParse(input[0].ToString(), out row);
                bool validCol = int.TryParse(input[2].ToString(), out col);

                if (validRow && validCol && (row < Game.Rows) && (col < Game.Cols))
                {
                    validatedString = "turn";
                }

                currentGame.Row = row;
                currentGame.Col = col;
            }

            return validatedString;
        }
    }
}
