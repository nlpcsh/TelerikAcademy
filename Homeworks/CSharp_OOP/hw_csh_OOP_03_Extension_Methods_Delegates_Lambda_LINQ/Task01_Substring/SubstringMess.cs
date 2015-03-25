/* Task 1 - Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and has the same functionality as Substring in the class String.
  */
namespace Task01_Substring
{
    using System;
    using System.Text;

    class SubstringMess
    {
        static void Main()
        {
            var someStrBuilder = new StringBuilder();

            someStrBuilder.Append("Here is some text");

            int index = 5;
            int length = 2;

            var resultSubstr = someStrBuilder.Substring(index, length);

            Console.WriteLine(" Initial string is: {0}", someStrBuilder);
            Console.WriteLine(" Substring from index {0} and lenght {1} is: {2}", index, length, resultSubstr);
        }
    }
}
