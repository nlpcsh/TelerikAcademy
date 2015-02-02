using System;

class GameOfPage
{
    static void Main()
    {
        int[,] board = new int[16,16];

        // readind the input map
        for (int i = 0; i < 16 ; i++)
        {
            string lineInut = Console.ReadLine();

            int j = 0;
            foreach (char digit in lineInut)
            {
                string strDigit = Convert.ToString(digit);
                board[i, j] = int.Parse(strDigit);
                j++;
            }

        }
        //Console.WriteLine();
        //for (int i = 0; i < 16; i++)
        //{
        //    for (int j = 0; j < 16; j++)
        //    {
        //        Console.Write(board[i, j]);
        //    }
        //    Console.WriteLine();
        //}

        // reading the question:
        string questionIs = "";
        int row = 0, col=0;
        int cookieCounter = 0;
        bool doAsk = true;

        while (doAsk)
        {
            questionIs = Console.ReadLine();
            //Console.WriteLine(questionIs);
            if (questionIs == "paypal")
            {
                Console.WriteLine("{0:F2}", cookieCounter * 1.79);
                break;
            }
            row = int.Parse(Console.ReadLine());
            col = int.Parse(Console.ReadLine());

            if (board[row, col] == 1)
            {
                if ((row == 0 || row == 15) || (col == 0 || col == 15))
                {
                    Console.WriteLine("broken cookie");
                }
                else
                {
                    if ((board[row+1, col] == 1) || (board[row-1, col] == 1))
                    {
                        if ((board[row+1, col+1] == 1) && (board[row-1, col-1] == 1))
                        {
                            
                            if (questionIs == "buy")
                            {
                                cookieCounter++;
                            }
                            else
                            {
                                Console.WriteLine("cookie");
                            }
                        }
                        else
                        {
                            Console.WriteLine("broken cookie");
                        }
                    }
                    else
                    {
                        Console.WriteLine("cookie crumb");
                    } 
                }
            }
            else
            {
                if (questionIs == "buy")
                {
                    Console.WriteLine("page");
                }
                else
                {
                    Console.WriteLine("smile");
                }
            }
        } 
    }
}
