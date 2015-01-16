// Task 14 - Find online more information about ASCII (American Standard Code for Information Interchange) 
//   and write a program that prints the entire ASCII table of characters on the console 
//   (characters from 0 to 255)

using System;

class PrintASCII
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine(" Printing ASCII table from 0 to 255: ");

        //skip characters that cannot be displayed "000"
        for ( int i = 0; i <= 255; i++)
        {
            Console.WriteLine("{0} = {1}", i, (char)i);
        }
    }
}

