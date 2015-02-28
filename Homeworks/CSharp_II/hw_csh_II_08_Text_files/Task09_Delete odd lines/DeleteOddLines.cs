/* Task 9 
    Write a program that deletes from given text file all odd lines.
    The result should be in the same file.
*/

using System.IO;

class DeleteOddLines
{
    static void Main()
    {
        string[] lines = File.ReadAllLines("../../text.txt");

        using (StreamWriter writer = new StreamWriter("../../text.txt"))
        {
            for (int i = 0; i < lines.Length; i++)
            {
                if (i % 2 != 0)
                {
                    writer.WriteLine(lines[i]);
                }
            }
            System.Console.WriteLine("Complete!");
        }
    }
}

