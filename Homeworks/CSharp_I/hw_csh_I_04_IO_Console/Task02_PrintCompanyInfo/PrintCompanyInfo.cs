// Task 2 - A company has name, address, phone number, fax number, web site 
//   and manager. The manager has first name, last name, age and a phone number.
//  Write a program that reads the information about a company and its manager
//    and prints it back on the console.

using System;

class PrintCompanyInfo
{
    static void Main()
    {
        Console.WriteLine(" Enter the following information about the company ");
        Console.Write(" Company name is: ");
        string companyName = Console.ReadLine();
        Console.Write(" Company address is: ");
        string address = Console.ReadLine();
        Console.Write(" Phone number is: ");
        string phoneNumber = Console.ReadLine();
        Console.Write(" Fax number is: ");
        string faxNumber = Console.ReadLine();
        Console.Write(" Web site is: ");
        string webSite = Console.ReadLine();
        Console.Write(" Manager first name is: ");
        string managerFirstName = Console.ReadLine();
        Console.Write(" Manager last name is: ");
        string managerLasstName = Console.ReadLine();
        Console.Write(" Manager Age is: ");
        string managerAge = Console.ReadLine();
        Console.Write(" Manager phone is: ");
        string managerPhone = Console.ReadLine();

        Console.WriteLine();

        Console.WriteLine(" Company Information was entered:");
        Console.WriteLine(" Company name is: " + companyName);
        Console.WriteLine(" Company address is: " + address);
        Console.WriteLine(" Phone number is: " + phoneNumber);
        Console.WriteLine(" Fax number is: " + faxNumber);
        Console.WriteLine(" Web site is: " + webSite);
        Console.WriteLine(" Manager first name is: " + managerFirstName);
        Console.WriteLine(" Manager last name is: " + managerLasstName);
        Console.WriteLine(" Manager Age is: " + managerAge);
        Console.WriteLine(" Manager phone is: " + managerPhone);


    }
}

