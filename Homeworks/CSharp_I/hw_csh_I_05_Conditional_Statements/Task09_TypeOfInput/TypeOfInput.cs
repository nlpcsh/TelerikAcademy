// Task 9 - Write a program that, depending on the user’s choice, inputs an int, double 
// or string variable.
//        If the variable is int or double, the program increases it by one.
//        If the variable is a string, the program appends * at the end.
//    Print the result at the console. Use switch statement.

using System;

class TypeOfInput
{
    static void Main()
    {
        Console.WriteLine(" int    - > 1 ");
        Console.WriteLine(" double - > 2 ");
        Console.WriteLine(" string - > 3 ");
        Console.Write(" Please, choose a variable type: ");
        string inputType = Console.ReadLine();

        Console.Write(" Set a value to the variable: ");

        switch (inputType)
        {
            case "1":
                int inputInt = int.Parse(Console.ReadLine());
                inputInt += 1;
                Console.WriteLine(" Result is: {0}", inputInt);
                break;
            case "2":
                double inputReal = double.Parse(Console.ReadLine());
                inputReal += 1;
                Console.WriteLine(" Result is: {0}", inputReal);
                break;
            case "3":
                string inputString = Console.ReadLine();
                Console.WriteLine(" Result is: " + inputString + "*");
                break;
            default:
                Console.WriteLine(" Not a legal input! ");
                break;
        }

    }
}

