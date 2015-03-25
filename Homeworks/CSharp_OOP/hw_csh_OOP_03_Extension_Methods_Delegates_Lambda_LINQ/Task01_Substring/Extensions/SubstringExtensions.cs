
namespace Task01_Substring
{
    using System;
    using System.Text;

    public static class SubstringExtensions
    {
        public static StringBuilder Substring(this StringBuilder input, int index, int length)
        {
 
            string innpurStr = input.ToString();
            string subStr = innpurStr.Substring(index, length);

            var result = new StringBuilder();
            result.Append(subStr);

            return result;
        }
    }
}
