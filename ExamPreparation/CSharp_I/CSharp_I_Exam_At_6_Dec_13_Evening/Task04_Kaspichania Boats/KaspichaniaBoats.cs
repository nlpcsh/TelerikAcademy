using System;

class KaspichaniaBoats
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        //int colBottom = 0;


        int boatWidth = (2 * N) + 1;
        //Console.WriteLine(boatWidth);

        for (int row = 0, j=N, k=N; row < N; row++, j--, k++)
        {
            for (int col = 0; col < N; col++)
            {
                if (j == col)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }

            Console.Write("*");

            for (int col = N + 1; col < boatWidth; col++)
            {

                if (k == col )
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }

            Console.WriteLine();
        }
        // end of upper part

        for (int i = 0; i < boatWidth; i++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
        // end of middle part

        int bottom = 6 + ((N - 3) / 2) * 3 - N - 2 ;
        

        for (int row = 0, j = N, k = N; row < bottom; row++, j--, k++)
        {

            for (int col = N + 1; col < boatWidth; col++)
            {

                if (k+2 == col)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
                
            }

            Console.Write("*");

            for (int col = 0; col < N; col++)
            {
                if (j-2 == col)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }

            Console.WriteLine();
        }
        // end of bottom part

        for (int i = 0; i < boatWidth; i++)
        {
            if ((i < bottom+1) || (i > boatWidth - bottom - 2))
            {
                Console.Write(".");
            }
            else
            {
                Console.Write("*");
            }
        }

        Console.WriteLine();

        //Console.WriteLine(bottom);
        //Console.WriteLine(colBottom);
    }
}

