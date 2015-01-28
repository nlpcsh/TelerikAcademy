// Task 4 - Write a program that generates and prints all possible cards from a
//   standard deck of 52 cards (without the jokers). The cards should be printed
//   using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and
//   K of diamonds).
// The card faces should start from 2 to A.
// Print each card face in its four possible suits: clubs, diamonds, hearts and
//   spades. 
// Use 2 nested for-loops and a switch-case statement.

using System;

class PrintCardsDeck
{
    static void Main()
    {
        for (int i = 2; i < 15; i++)
        {
            // play card's colors
            string[] playColors = { "\u2660", "\u2665", "\u2666", "\u2663"};

            for (int j = 0; j < 4; j++)
            {
                if (i < 11)
                {
                    Console.Write(" {0} of {1} ", i, playColors[j]);
                }
                else
                {
                    switch (i)
                    {
                        case 11:
                            Console.Write(" J of {0} ", playColors[j]);
                            break;
                        case 12:
                            Console.Write(" Q of {0} ", playColors[j]);
                            break;
                        case 13:
                            Console.Write(" K of {0} ", playColors[j]);
                            break;
                        case 14:
                            Console.Write(" A of {0} ", playColors[j]);
                            break;
                        default:
                            Console.WriteLine(" Out of range ");
                            break;
                    }
                }
            }
            Console.WriteLine();
        }
    }
}

