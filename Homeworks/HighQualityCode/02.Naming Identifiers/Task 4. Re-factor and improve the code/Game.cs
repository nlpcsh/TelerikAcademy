namespace MineSweeperGame
{
    using System;
    using System.Collections.Generic;

    internal class Game
    {
        public const int Rows = 5;
        public const int Cols = 10;
        public const int NumberOfMines = 15;
        public const int NonMinedPlaces = (Rows * Cols) - NumberOfMines;
        
        private Random random = new Random();
        private int row;
        private int col;
        private string input = string.Empty;
        private int scoreCounter = 0;
        private char[,] field;
        private char[,] minesPositions;

        public Game()
        {
            this.field = this.CreateNewBoard();
            this.minesPositions = this.PlaceAllMines();
            this.ScoreCounter = 0;
        }

        public char[,] Field
        {
            get
            {
                return this.field;
            }
        }

        public char[,] MinesPositions
        {
            get
            {
                return this.minesPositions;
            }
        }

        public int ScoreCounter
        {
            get
            {
                return this.scoreCounter;
            }

            set
            {
                this.scoreCounter = value;
            }
        }

        // it is set in the Input class
        public int Row
        {
            get
            {
                return this.row;
            }

            set
            {
                this.row = value;
            }
        }

        public int Col 
        { 
            get 
            { 
                return this.col; 
            } 

            set 
            { 
                this.col = value; 
            } 
        }

        internal string MakeTurn()
        {
            if (this.minesPositions[this.Row, this.Col] != '*')
            {
                if (this.minesPositions[this.Row, this.Col] == '-')
                {
                    RevealCurrentPosition(this.field, this.minesPositions, this.Row, this.Col);
                    this.ScoreCounter++;
                }

                if (NonMinedPlaces == this.ScoreCounter)
                {
                    return "finish";
                }
                else
                {
                    Output.PrintBoard(this.field);
                }
            }
            else
            {
                return "mine";
            }

            return "goOn";
        }

        private static void RevealCurrentPosition(char[,] board, char[,] minesPositions, int row, int col)
        {
            char numberOfMinesArround = FindNumberOfMinesArround(minesPositions, row, col);
            minesPositions[row, col] = numberOfMinesArround;
            board[row, col] = numberOfMinesArround;
        }

        private static char FindNumberOfMinesArround(char[,] field, int row, int col)
        {
            int count = 0;
            int rows = field.GetLength(0);
            int cols = field.GetLength(1);

            if (row - 1 >= 0)
            {
                if (field[row - 1, col] == '*')
                {
                    count++;
                }
            }

            if (row + 1 < rows)
            {
                if (field[row + 1, col] == '*')
                {
                    count++;
                }
            }

            if (col - 1 >= 0)
            {
                if (field[row, col - 1] == '*')
                {
                    count++;
                }
            }

            if (col + 1 < cols)
            {
                if (field[row, col + 1] == '*')
                {
                    count++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (field[row - 1, col - 1] == '*')
                {
                    count++;
                }
            }

            if ((row - 1 >= 0) && (col + 1 < cols))
            {
                if (field[row - 1, col + 1] == '*')
                {
                    count++;
                }
            }

            if ((row + 1 < rows) && (col - 1 >= 0))
            {
                if (field[row + 1, col - 1] == '*')
                {
                    count++;
                }
            }

            if ((row + 1 < rows) && (col + 1 < cols))
            {
                if (field[row + 1, col + 1] == '*')
                {
                    count++;
                }
            }

            return char.Parse(count.ToString());
        }

        private char[,] CreateNewBoard()
        {
            char[,] field = new char[Game.Rows, Game.Cols];

            for (int i = 0; i < Game.Rows; i++)
            {
                for (int j = 0; j < Game.Cols; j++)
                {
                    field[i, j] = '?';
                }
            }

            return field;
        }

        private char[,] PlaceAllMines()
        {
            char[,] minesPositions = new char[Game.Rows, Game.Cols];

            for (int i = 0; i < Game.Rows; i++)
            {
                for (int j = 0; j < Game.Cols; j++)
                {
                    minesPositions[i, j] = '-';
                }
            }

            List<int> minesList = new List<int>();

            while (minesList.Count <= NumberOfMines)
            {
                int currentMine = this.random.Next(50);

                if (!minesList.Contains(currentMine))
                {
                    minesList.Add(currentMine);
                }
            }

            foreach (int mine in minesList)
            {
                int col = mine / Cols;
                int row = mine % Cols;

                if (row == 0 && mine != 0)
                {
                    col--;
                    row = Cols;
                }
                else
                {
                    row++;
                }

                minesPositions[col, row - 1] = '*';
            }

            return minesPositions;
        }
    }
}
