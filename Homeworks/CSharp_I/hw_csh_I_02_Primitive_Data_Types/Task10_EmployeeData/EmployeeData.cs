// Task 10 - A marketing company wants to keep record of its employees. Each record 
//   would have the following characteristics:
//
//    First name
//    Last name
//    Age (0...100)
//    Gender (m or f)
//    Personal ID number (e.g. 8306112507)
//    Unique employee number (27560000…27569999)
//
// Declare the variables needed to keep the information for a single employee using
//   appropriate primitive data types. Use descriptive names. Print the data at the console.

using System;

class EmployeeData
{
    static void Main()
    {
        string firstName = "Misho";
        string lastName = "Peshev";
        char gender = 'm' ;
        byte age = 33;
        ulong personalID = 8306112507;
        uint uniqueEmployeeNumber = 27569999;

        Console.WriteLine(" Full name: {0} {1} \n Gender: {2} \n Age: {3} \n Personal ID: {4} \n Unique Number: {5} ",
            firstName, lastName, gender, age, personalID, uniqueEmployeeNumber);
    }
}

