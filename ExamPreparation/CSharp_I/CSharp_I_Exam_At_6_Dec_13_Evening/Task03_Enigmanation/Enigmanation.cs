using System;

class Enigmanation
{
    static void Main()
    {
        string inputText = Console.ReadLine();
        int counter = 0;
        int result = 0;
        int nextDigit = 0;
        int currentResult = 0;
        char operation = ' ';
        char savedOperation = ' ';
        bool inBrackets = false;
        bool isFirst = true;
        //bool isEnd = false;
        int resultInBrackets = 0;

        foreach (char symbol in inputText)
        {
           

            switch (symbol)
            {
                case '(':
                    inBrackets = true;
                    isFirst = true;
                    savedOperation = operation;
                    result = currentResult;
                    continue;
                //break;
                case ')':
                    if (result == 0)
                    {
                        result = resultInBrackets;
                    }
                    else
                    {
                        result = PerformeOperation(result, resultInBrackets, savedOperation);
                        currentResult = result;
                    }
                    inBrackets = false;
                    continue;
                //break;
                default:
                    break;
            }

            // take the number
            if (counter % 2 == 0)
            {
                // Take the first number
                if (isFirst)
                {
                    currentResult = ReturnNumberFromChar(symbol);
                    isFirst = false;
                }
                // Take every number after the first and perform the operation with the previous number/result
                else
                {
                    nextDigit = ReturnNumberFromChar(symbol);
                    currentResult = PerformeOperation(currentResult, nextDigit, operation);

                    // if not in the brackets -> save the current result and operation
                    if (!inBrackets)
                    {
                        result = currentResult;
                        savedOperation = operation;
                    }
                    // if in the brackets!!!
                    else
                    {
                        resultInBrackets = currentResult;
                        //isFirst = true;
                    }
                }
            }
            // take the operator
            else
            {
                operation = symbol;
            }

            if (symbol == '=')
            {
                break;
            }

            counter++;
            //Console.WriteLine(" ----------------------------------- ");
            //Console.WriteLine(" Step is: {0}", counter);
            //Console.WriteLine(" Current Result is: {0}", currentResult);
            //Console.WriteLine(" Result is: {0}", result);
            //Console.WriteLine(" Operation is: {0} ", operation);
            //Console.WriteLine(" saved operation is: {0}", savedOperation);
        }

        Console.WriteLine("{0:F3}", result);
    }

    static public int PerformeOperation(int currentResult, int nextDigit, char operation)
    {
        switch (operation)
        {
            case '*':
                currentResult = currentResult * nextDigit;
                break;
            case '%':
                currentResult = currentResult % nextDigit;
                break;
            case '-':
                currentResult = currentResult - nextDigit;
                break;
            case '+':
                currentResult = currentResult + nextDigit;
                break;
            default:
                break;
        }
        return currentResult;
    }

    static public int ReturnNumberFromChar(char symbol)
    {
        int number = 0;
        switch (symbol)
        {
            case '1': number = 1; break;
            case '2': number = 2; break;
            case '3': number = 3; break;
            case '4': number = 4; break;
            case '5': number = 5; break;
            case '6': number = 6; break;
            case '7': number = 7; break;
            case '8': number = 8; break;
            case '9': number = 9; break;
            default: break;
        }
        return number;
    }
}


