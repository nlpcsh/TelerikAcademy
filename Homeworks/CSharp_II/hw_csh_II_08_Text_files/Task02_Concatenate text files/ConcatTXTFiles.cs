// Task 2 - Write a program that concatenates two text files into another text file.

//using System;
using System.IO;

class ConcatTXTFiles
{
    static void Main()
    {
        using (var output = File.Create("..//..//output_concat.txt"))
        {
            foreach (var file in new[] { "..//..//file1.txt", "..//..//file2.txt" })
            {
                using (var input = File.OpenRead(file))
                {
                    input.CopyTo(output);
                }
            }
        }
    }
}

