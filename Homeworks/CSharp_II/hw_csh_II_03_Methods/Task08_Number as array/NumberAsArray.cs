// Task 8 - Write a method that adds two positive integer numbers 
//    represented as arrays of digits (each array element arr[i] contains a digit; 
//    the last digit is kept in arr[0]).
//  Each of the numbers that will be added could have up to 10 000 digits.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NumberAsArray
{
    static void Main()
    {
        Console.WriteLine(" Enter 2 integers > 0 to be added using arrays of digits");
        Console.Write(" Integer 1: ");
        string strNumber1 = Console.ReadLine();
        Console.Write(" Integer 2: ");
        string strNumber2 = Console.ReadLine();

        AddTwoNumbersAsArrays(strNumber1, strNumber2);

    }

    static void AddTwoNumbersAsArrays(string nb1, string nb2)
    {
        int[] sum = new int[100];

        int minLength = 0;

        int[] intArr1 = ConverseStringToArray(nb1);
        int[] intArr2 = ConverseStringToArray(nb2);

        if (intArr1.Length > intArr2.Length)
        {
            for (int i = 0; i < intArr1.Length; i++)
            {
                sum[i] = intArr1[i];
            }
            minLength = intArr2.Length;
        }
        else
        {
            for (int i = 0; i < intArr1.Length; i++)
            {
                sum[i] = intArr1[i];
            }
            minLength = intArr1.Length;
        }

        for (int i = 0; i < minLength; i++)
        {
           
            sum[i] += intArr2[i];
            if (sum[i] > 9)
            {
                sum[i] = sum[i] % 10;
                sum[i + 1] += 1;
            }
            if (sum[i+1] > 9)
            {
                sum[i+1] = sum[i+1] % 10;
                sum[i + 2] += 1;
            }
            
        }

        PrintFinalResult(sum);
    }

    static void PrintFinalResult(int[] sum)
    {

        string result = string.Empty;

        foreach (var item in sum)
        {
            result += item.ToString();
        }

        char[] charArray = result.ToCharArray();

        Array.Reverse(charArray);

        string strRes = new string(charArray);

        strRes = strRes.Trim('0');

        Console.WriteLine(strRes);
    }

    static int[] ConverseStringToArray(string number)
    {
        char[] numbersAsChars = number.ToCharArray();
        int[] intArray = new int[numbersAsChars.Length];

        for (int i = 0, j = numbersAsChars.Length - 1; i < numbersAsChars.Length; i++, j--)
        {
            intArray[j] = int.Parse(numbersAsChars[i].ToString());
        }

        return intArray;
    }
}
