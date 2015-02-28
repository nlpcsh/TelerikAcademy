/* Task 1
    Write a program that reads an integer number and calculates and prints its square root.
        If the number is invalid or negative, print Invalid number.
        In all cases finally print Good bye.
    Use try-catch-finally block.
*/

using System;

class SquareRoot
{
    static double Sqrt(double value)
    {
        if (value < 0)
        {
            throw new System.ArgumentException("Sqrt for negative numbers is undefined!");
        }
        return Math.Sqrt(value);
    }

    static void Main()
    {
        Console.Write("Enter an integer: ");
        try
        {
            int number = int.Parse(Console.ReadLine());
            double sqRoot = Sqrt(number);
            Console.WriteLine(" Square Root = {0}", sqRoot);
        }
        //catch (ArgumentOutOfRangeException aore)
        //{
        //    Console.Error.WriteLine("Exception caught: " + aore);
        //}
        catch (FormatException fe)
        {
            Console.Error.WriteLine("Exception caught: " + fe);
            Console.Error.WriteLine("\nMessage: " + fe.Message);
            Console.Error.WriteLine("\nStack Trace: " + fe.StackTrace);
        }
        catch (OverflowException oe)
        {
            Console.WriteLine("The number is too big to fit in Int32!");
            Console.Error.WriteLine("Exception caught: " + oe);
        }
        //catch (ArithmeticException ae)
        //{
        //    Console.Error.WriteLine("Exception caught: " + ae);
        //}
        finally
        {
            Console.WriteLine("Good Buy!");
        }
    }
}

