
namespace Education_3D
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Matrix<T> where T : IComparable
    {

        private T[,] matrix;

        public int Rows { get { return this.matrix.GetLength(0); } }
        public int Cols { get { return this.matrix.GetLength(1); } }

        public Matrix(int rows, int cols)
        {
            this.matrix = new T[rows, cols];
        }

        public T this[int row, int col]
        {
            get
            {
                if ((row < 0) || (row >= this.Rows))
                {
                    throw new IndexOutOfRangeException(String.Format("Invalid number of rows: {0}.", row));
                }
                if ((col < 0) || (col >= this.Rows))
                {
                    throw new IndexOutOfRangeException(String.Format("Invalid number of cols: {0}.", col));
                }
                return this.matrix[row, col];
            }
            set
            {
                if ((row < 0) || (row >= this.Rows))
                {
                    throw new IndexOutOfRangeException(String.Format("Invalid number of rows: {0}.", row));
                }
                if ((col < 0) || (col >= this.Rows))
                {
                    throw new IndexOutOfRangeException(String.Format("Invalid number of cols: {0}.", col));
                }
                this.matrix[row,col] = value;
            }

        }

        public static Matrix<T> operator +(Matrix<T> T1, Matrix<T> T2)
        {
            if (T1.Rows != T2.Rows || T1.Cols != T2.Cols)
            {
                throw new ArgumentException("Matrices must have the same number of rows and the same number of columns");
            }
            var sumMatrix = new Matrix<T>(T1.Rows, T1.Cols);

            for (int row = 0; row < T1.Rows; row++)
            {
                for (int col = 0; col < T1.Cols; col++)
                {
                    sumMatrix[row, col] = (dynamic)T1[row, col] + T2[row, col];
                }
            }
            return sumMatrix;
        }

        public static Matrix<T> operator -(Matrix<T> T1, Matrix<T> T2)
        {
            if (T1.Rows != T2.Rows || T1.Cols != T2.Cols)
            {
                throw new ArgumentException("Matrices must have the same number of rows and the same number of columns");
            }
            var sumMatrix = new Matrix<T>(T1.Rows, T1.Cols);

            for (int row = 0; row < T1.Rows; row++)
            {
                for (int col = 0; col < T1.Cols; col++)
                {
                    sumMatrix[row, col] = (dynamic)T1[row, col] - T2[row, col];
                }
            }
            return sumMatrix;
        }

        public static Matrix<T> operator *(Matrix<T> T1, Matrix<T> T2)
        {
            if (T1.Rows != T2.Cols)
            {
                throw new ArgumentException("Matrices 1 must have the same number of rows as Matrix 2 - number of columns");
            }
            var multMatrix = new Matrix<T>(T1.Rows, T1.Cols);
            T result = (dynamic)0;

            for (int row = 0; row < T1.Rows; row++)
            {
                for (int col = 0; col < T1.Cols; col++)
                {
                    for (int i = 0; i < T1.Cols; i++)
                    {
                        result += (dynamic)T1[row, i] - T2[i, row];
                    }
                    multMatrix[row, col] = result;
                    result = (dynamic)0;
                }
            }
            return multMatrix;
        }

        public static bool operator true(Matrix<T> matrix)
        {
            for (int row = 0; row < matrix.Rows; row++)
            {
                for (int col = 0; col < matrix.Cols; col++)
                {
                    if (matrix[row,col] == (dynamic)0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            for (int row = 0; row < matrix.Rows; row++)
            {
                for (int col = 0; col < matrix.Cols; col++)
                {
                    if (matrix[row, col] == (dynamic)0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public Matrix<T> PutSomeValues(Matrix<T> matrix, T t)
        {
            for (int row = 0; row < matrix.Rows; row++)
            {
                for (int col = 0; col < matrix.Cols; col++)
                {
                    matrix[row, col] = t;
                }
            }
            return matrix;
        }

        public void PrintMatrix()
        {
            for (int row = 0; row < this.Rows; row++)
            {
                for (int col = 0; col < this.Cols; col++)
                {
                   Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
