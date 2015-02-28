// Task 1 - Write a program that reads a text file and prints on the console its odd lines.

//using System;
using System.IO;

class OddLines
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"../../text.txt");

        string line = reader.ReadLine();
        int counter = 0;

        while (line != null)
        {
            line = reader.ReadLine();

            if (counter % 2 == 0)
            {
                System.Console.WriteLine(line);
            }

            counter++;
        }

        reader.Close();

    }
}

