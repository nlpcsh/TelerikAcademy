// Task 12 - Write a program that enters in integer n and prints the numbers
//    1, 2, …, n in random order.

using System;

class Randomize1toN
{
    static void Main()
    {
        Console.Write(" Enter the max value N of random integers to be generated, please: ");
        int nbRandom = int.Parse(Console.ReadLine());

        Random rnd = new Random();

        int[] arrayToRandomize = new int[nbRandom];

        Console.WriteLine(" Initial number sequence is: ");

        for (int i = 0; i < nbRandom; i++)
        {
            arrayToRandomize[i] = i + 1;
            Console.Write(" " + arrayToRandomize[i]);
        }

        // Knuth shuffle algorithm
        for (int t = 0; t < arrayToRandomize.Length; t++)
        {
            int tmp = arrayToRandomize[t];
            int r = rnd.Next(t, arrayToRandomize.Length);
            arrayToRandomize[t] = arrayToRandomize[r];
            arrayToRandomize[r] = tmp;
        }

        Console.WriteLine();

        Console.WriteLine(" Randomized number sequence: ");

        for (int i = 0; i < arrayToRandomize.Length; i++)
        {
            Console.Write(" " + arrayToRandomize[i]);
        }

        Console.WriteLine();
    }
}

