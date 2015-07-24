namespace CSharp2Exam
{
    using System;
    using System.Linq;
    using System.Numerics;

    internal class LoverOfTwo
    {
        private static int rows;
        private static int cols;
        private static int coef;
        private static int numberOfMoves;

        public static int Rows
        {
            get
            {
                return rows;
            }

            set
            {
                if (value < 1 || 100 < value)
                {
                    throw new ArgumentException("Rows are not in the range 1-100!");
                }

                rows = value;
            }
        }

        public static int Cols
        {
            get
            {
                return cols;
            }

            set
            {
                if (value < 1 || 75 < value)
                {
                    throw new ArgumentException("Cols are not in the range 1-75!");
                }

                cols = value;
            }
        }

        public static int NumberOfMoves
        {
            get
            {
                return numberOfMoves;
            }

            set
            {
                if (value < 1 || 1000 < value)
                {
                    throw new ArgumentException("NumberOfMoves is not in the range 1-1000!");
                }

                numberOfMoves = value;
            }
        }

        public static void Main()
        {
            try
            {
                Rows = int.Parse(Console.ReadLine());
                Cols = int.Parse(Console.ReadLine());
                NumberOfMoves = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                throw new FormatException("Input can not be parsed to int!");
            }

            coef = Math.Max(rows, cols);
            var moves = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int row = rows - 1;
            int col = 0;

            bool[,] used = new bool[rows, cols];

            MakeMoves(moves, row, col, used);

            BigInteger sum = GetTotalSum(used);

            Console.WriteLine(sum);
        }

        private static BigInteger GetTotalSum(bool[,] used)
        {
            BigInteger sum = 0;

            for (int r = 0; r < used.GetLength(0); r++)
            {
                for (int c = 0; c < used.GetLength(1); c++)
                {
                    if (used[r, c])
                    {
                        sum += GetValue(r, c, rows);
                    }
                }
            }

            return sum;
        }

        private static void MakeMoves(int[] moves, int row, int col, bool[,] used)
        {
            foreach (int move in moves)
            {
                int toRow = move / coef;
                int toCol = move % coef;

                while (row != toRow)
                {
                    used[row, col] = true;
                    if (row < toRow)
                    {
                        row++;
                    }
                    else
                    {
                        row--;
                    }
                }

                while (col != toCol)
                {
                    used[row, col] = true;
                    if (col < toCol)
                    {
                        col++;
                    }
                    else
                    {
                        col--;
                    }
                }

                used[row, col] = true;
            }
        }

        private static BigInteger GetValue(int row, int col, int rows)
        {
            return ((BigInteger)1) << (rows - row - 1 + col);
        }
    }
}
