/* Task 17 - Write a program to return the string with maximum length from an array of strings.
Use LINQ.
 */

namespace Task17_Longest_String
{
    using System;
    using System.Linq;

    class LongestString
    {
        static void Main()
        {
            string[] someStrings = "Write a program to return the string with maximum length from an array of strings".Split(' ');
            Console.WriteLine(" Initial string is: ");
            Console.WriteLine(string.Join(" ", someStrings));

            var sorted =
                from str in someStrings
                orderby str.Length descending
                select str;

            var maxLenght = sorted.FirstOrDefault();

            Console.WriteLine(" Max lenght string is: {0}", maxLenght);
        }
    }
}
