// Task 1 - Write a program that allocates array of 20 integers and initializes
//     each element by its index multiplied by 5.
//   Print the obtained array on the console.

using System;

class AllocateArray
{
    static void Main()
    {
        int[] twentyElements = new int[20];

        for (int i = 0; i < twentyElements.Length; i++)
        {
            twentyElements[i] = i * 5;
            Console.WriteLine(" index {0}  -  value  {1}", i, twentyElements[i]);
        }
    }
}

