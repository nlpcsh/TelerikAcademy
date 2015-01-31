// Task 10 - You are given n integers (given in a single line, separated by a space).
//   Write a program that checks whether the product of the odd elements is equal to 
//     the product of the even elements.
//   Elements are counted from 1 to n, so the first element is odd, the second is even, 
//     etc.

using System;

class OddAndEvenProduct
{
    static void Main()
    {
        Console.Write(" Line of integer numbers, please: ");
        string inputString = Console.ReadLine();
        string[] arrayOfNumbers = inputString.Split(' ');

        int productOfEven = 1;
        int productOfOdd = 1;

        for (int i = 0; i < arrayOfNumbers.Length; i++)
        {
            int arrayElement = int.Parse(arrayOfNumbers[i]);

            if (i % 2 != 0)
            {
                productOfEven *= arrayElement;
            }
            else
            {
                productOfOdd *= arrayElement;
            }
        }


        //foreach (string str in n)
        //{
        //    //Console.WriteLine(str);
        //    int strElement = int.Parse(str);

        //    if (strElement % 2 == 0)
        //    {
        //        productOfEven *= strElement;
        //    }
        //    else
        //    {
        //        productOfOdd *= strElement;
        //    }
        //}

        if (productOfEven == productOfOdd)
        {
            Console.WriteLine(" The products of Evens and Odds are equal to {0}!", productOfOdd);
        }
        else
        {
            Console.WriteLine(" The Evens' product {0} is not equal to the Odds' {1} !", productOfEven, productOfOdd);
        }
    }
}