namespace _02.Naming_Identifiers
{
    using System;

    internal class VariablePrinter
    {
        public const int MaxCounter = 6;

        public static void MakeVariablePrinter()
        {
            VariablePrinter.ToStringPrinter currentPrinter = new VariablePrinter.ToStringPrinter();
            currentPrinter.PrintVariable(true);
        }
        
        internal class ToStringPrinter
        {
            internal void PrintVariable(bool inputVariable)
            {
                string inputVariableToString = inputVariable.ToString();
                Console.WriteLine(inputVariableToString);
            }
        }
    }
}
