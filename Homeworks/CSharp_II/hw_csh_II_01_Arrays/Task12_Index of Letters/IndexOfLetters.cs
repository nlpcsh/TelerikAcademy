// Task 12 - Write a program that creates an array containing all letters from 
//     the alphabet (A-Z).
//   Read a word from the console and print the index of each of its letters in 
//     the array.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class IndexOfLetters
{
    static void Main()
    {
        char[] letters = new char[52];

        // letters
        for (char i = 'a'; i <= 'z'; i++)
        {
            letters[i - 'a'] = i;
        }
        // capital letters
        for (char i = 'A'; i <= 'Z'; i++)
        {
            letters[i - 'A' + 26] = i;
        }

        Console.WriteLine(" The array of letetrs is: ");
        Console.WriteLine(string.Join(",", letters));

        Console.Write(" Enter a word to chek its letter indexes: ");
        string word = Console.ReadLine();

        foreach (char L in word)
        {
            int index = 0;
            foreach (char c in letters)
            {
                if (c == L)
                {
                    Console.WriteLine("Letter '{0}' -> index: {1} -> ASCII index: {2}", L, index, (int)L);
                }
                index++;
            }
        }

    }
}

