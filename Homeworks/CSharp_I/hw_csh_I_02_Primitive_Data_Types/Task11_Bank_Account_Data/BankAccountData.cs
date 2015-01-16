// Task 11 - A bank account has a holder name (first name, middle name and last name), 
//   available amount of money (balance), bank name, IBAN, 3 credit card numbers associated 
//   with the account.
//  Declare the variables needed to keep the information for a single bank account using 
//   the appropriate data types and descriptive names.

using System;

class BankAccountData
{
    static void Main()
    {
        string firstName = "Misho";
        string middleName = "Ivanov";
        string lastName = "Peshev";
        string bankName = "FIB";
        string iban = "ISISAN28018HHKAK";
        ulong creditCard1 = 8938298938201028;
        ulong creditCard2 = 8938298228201028;
        ulong creditCard3 = 8938298118201028;
        decimal ballance = -200.02M;

        Console.WriteLine(" Full name: {0} {1} {2} \n Bank: {3} \n IBAN: {4} \n Credit Card 1: {5} \n Credit Card 2: {6} \n Credit Card 3: {7} \n Account Balance: {8} ",
            firstName, middleName, lastName, bankName, iban, creditCard1, creditCard2, creditCard3, ballance);
    }
}

