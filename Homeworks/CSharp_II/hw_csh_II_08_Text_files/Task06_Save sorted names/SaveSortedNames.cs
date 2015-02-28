/* Task 6 
    Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
*/

//using System;
using System.Linq;
using System.IO;

class SaveSortedNames
{
    static void Main()
    {
        string[] fileLines = File.ReadLines("..//..//file.txt").ToArray();
        System.Array.Sort(fileLines);
        File.WriteAllLines("..//..//sortedFile.txt", fileLines);
    }
}

