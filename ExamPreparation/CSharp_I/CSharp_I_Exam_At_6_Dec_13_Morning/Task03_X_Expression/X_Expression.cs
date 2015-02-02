using System;

class X_Expression
{
    static void Main()
    {
        string expression = Console.ReadLine();
        char currentOperator = '+';
        decimal result = 0;
        decimal currentBracketResult = 0;
        bool inBracket = false;
        char currentBracketOperator = '+';

        foreach (char symbol in expression)
        {
            //if (symbol == '=')
            //{
            //    break;
            //}

            if (symbol == '(')
            {
                inBracket = true;
                continue;
            }

            if (symbol == ')')
            {
                switch (currentOperator)
                {
                    case '+': result += currentBracketResult;
                        break;
                    case '-': result -= currentBracketResult;
                        break;
                    case '*': result *= currentBracketResult;
                        break;
                    case '/': result /= currentBracketResult;
                        break;
                    default:
                        break;
                }
                currentBracketResult = 0;
                currentBracketOperator = '+';
            }

            if ((symbol == '+' ) || (symbol == '-') || (symbol == '*') || (symbol == '/') )
            {
                if (inBracket)
                {
                    currentBracketOperator = symbol;
                }
                else
                {
                    currentOperator = symbol;
                }
            }

            if (symbol >= '0' && symbol <= '9')
            {
                int currentNumber = symbol - '0';

                if (inBracket)
                {
                    switch (currentBracketOperator)
                    {
                        case '+': currentBracketResult += currentNumber;
                            break;
                        case '-': currentBracketResult -= currentNumber;
                            break;
                        case '*': currentBracketResult *= currentNumber;
                            break;
                        case '/': currentBracketResult /= currentNumber;
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    switch (currentOperator)
                    {
                        case '+': result += currentNumber;
                            break;
                        case '-': result -= currentNumber;
                            break;
                        case '*': result *= currentNumber;
                            break;
                        case '/': result /= currentNumber;
                            break;
                        default:
                            break;
                    }
                }
            }
        }
        Console.WriteLine("{0:F2}",result);
    }
}

