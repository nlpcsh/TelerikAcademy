/* Problem 2. Bank accounts

A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. Customers could be individuals or companies.
All accounts have customer, balance and interest rate (monthly based).
Deposit accounts are allowed to deposit and with draw money.
Loan and mortgage accounts can only deposit money.
All accounts can calculate their interest amount for a given period (in months). In the common case its is calculated as follows: number_of_months * interest_rate.
Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held by a company.
Deposit accounts have no interest if their balance is positive and less than 1000.
Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
Your task is to write a program to model the bank system by classes and interfaces.
You should identify the classes, interfaces, base classes and abstract actions and implement the calculation of the interest functionality through overridden methods.
 */

namespace Task02_Bank_accounts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class RunProgram
    {
        static void Main()
        {
            // create a person and a company
            var somePersone = new Individual("Pesho");
            var someCOmpany = new Company("Unlimited fun Ltd.");
            
            // create some accounts:
            var someDepositAccount = new DepositAccount(somePersone, 1100m, 0.05m / 12);
            var someLoanAccount = new LoanAccount(someCOmpany, 1000m, 0.09m / 12);
            var anotherLoanAccount = new LoanAccount(somePersone, 100m, 0.09m / 12);
            var someMortgageAccount = new MortgageAccounts(somePersone, 4000m, 0.1m / 12);


            // Interest of a company holder
            Console.WriteLine(someLoanAccount.ToString());
            someLoanAccount.CalculateInterest();
            Console.WriteLine();

            // Interest of a person holder
            Console.WriteLine(anotherLoanAccount.ToString());
            anotherLoanAccount.CalculateInterest();
            Console.WriteLine();

            // Interest of the mortgage account
            Console.WriteLine(someMortgageAccount.ToString());
            someMortgageAccount.CalculateInterest();
            Console.WriteLine();

            // interest of a deposit account
            Console.WriteLine(someDepositAccount.ToString());
            someDepositAccount.CalculateInterest(); 
            Console.WriteLine();

            // withdraw some money form a deposit
            someDepositAccount.WithdrawMoney(200m);
            Console.WriteLine(someDepositAccount.ToString());
            someDepositAccount.CalculateInterest();
            Console.WriteLine();

        }
    }
}
