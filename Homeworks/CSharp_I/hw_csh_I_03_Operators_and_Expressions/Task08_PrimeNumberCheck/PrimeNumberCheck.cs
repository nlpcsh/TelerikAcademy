// Task 8 - Write an expression that checks if given positive integer number
//   n (n = 100) is prime (i.e. it is divisible without remainder only to
//   itself and 1).

using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.Write(" Enter number from 0 to 100 to check if it is prime: ");
        int inputNumber = int.Parse(Console.ReadLine());

        bool isTrue = true;

        // check if the number is in the range 0-100 
        while (isTrue)
        {
            if ((100 - Math.Abs(inputNumber) < 0) ^ (inputNumber <= 0))
            {
                Console.Write("The number is not in the range 1-100! Try again: ");
                inputNumber = int.Parse(Console.ReadLine());
            }
            else
            {
                isTrue = false;
            }
        }

        int checkIfPrime2 = inputNumber % 2  ;
        int checkIfPrime3 = inputNumber % 3  ;
        int checkIfPrime5 = inputNumber % 5  ;
        int checkIfPrime7 = inputNumber % 7  ;

        Console.WriteLine(checkIfPrime2);
        Console.WriteLine(checkIfPrime3);
        Console.WriteLine(checkIfPrime5);
        Console.WriteLine(checkIfPrime7);

        string primeOrNot = "";

        if ((inputNumber == 2) ^ (inputNumber == 3) ^ (inputNumber == 5) ^ (inputNumber == 7))
        {
            primeOrNot = " Is prime!" ;
        }
        else
        {
            primeOrNot = ((checkIfPrime2 != 0) && (checkIfPrime3 != 0) && (checkIfPrime5 != 0) && (checkIfPrime7 != 0)) ? " Is prime!" : " Sorry, it is not prime!!!";
        }

        Console.WriteLine(primeOrNot) ;
    }
}

