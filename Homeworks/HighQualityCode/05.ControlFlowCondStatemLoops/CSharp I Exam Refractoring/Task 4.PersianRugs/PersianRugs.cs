namespace Task_4.PersianRugs
{
    using System.Text;

    public class PersianRugs
    {
        private const char LeftSym = '\\';
        private const char RightSym = '/';
        private const char Space = ' ';
        private const char Diez = '#';
        private const char Center = 'X';
        private const char Dot = '.';

        public static void Main()
        {
            int size = ReadInputNumber();
            int div = ReadInputNumber() + 1;

            StringBuilder carpet = new StringBuilder();

            int doubleSize = 2 * size;
            int carpetSize = doubleSize + 1;

            for (int row = 0; row < carpetSize; row++)
            {
                for (int col = 0; col < carpetSize; col++)
                {
                    if (col == size && row == size)
                    {
                        carpet.Append(Center);
                    }
                    else if (((row + col == doubleSize) ||
                        (row + col == doubleSize + div)) && ((col < size) ||
                        (row + col == doubleSize - div)) && ((col > size) ||
                        (row + col == (4 * size) + 2)))
                    {
                        carpet.Append(RightSym);
                    }
                    else if (((row - col == 0) ||
                        (row - col == -div)) && ((col < size) ||
                        (row - col == div)) && ((col > size) ||
                        (row - col == doubleSize + 2)))
                    {
                        carpet.Append(LeftSym);
                    }
                    else if ((row - col >= 0) && ((row + col <= doubleSize) ||
                        (row + col >= doubleSize)) && (row - col <= 0))
                    {
                        carpet.Append(Diez);
                    }
                    else if ((row + col >= doubleSize + div) &&
                        ((row - col > div) ||
                        (row + col <= doubleSize - div)) &&
                        (row - col < -div))
                    {
                        carpet.Append(Dot);
                    }
                    else
                    {
                        carpet.Append(Space);
                    }
                }

                if (row != carpetSize - 1)
                {
                    carpet.AppendLine();
                }
            }

            System.Console.WriteLine(carpet);
        }

        private static int ReadInputNumber()
        {
            try
            {
                int input = int.Parse(System.Console.ReadLine());
                return input;
            }
            catch (System.FormatException)
            {
                throw new System.FormatException("Error in the input data!");
            }
        }
    }
}
