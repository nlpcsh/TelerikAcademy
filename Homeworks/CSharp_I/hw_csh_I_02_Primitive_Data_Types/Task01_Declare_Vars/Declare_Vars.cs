// Task 1 - Declare five variables choosing for each of them the most appropriate of the types:
//   byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 
//   52130, -115, 4825932, 97, -10000.
// Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.

// sbyte (-128 to 127): signed 8-bit
// byte (0 to 255): unsigned 8-bit
// short (-32,768 to 32,767): signed 16-bit
// ushort (0 to 65,535): unsigned 16-bit
// int (-2,147,483,648 to 2,147,483,647): signed 32-bit
// uint (0 to 4,294,967,295): unsigned 32-bit
// long (-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807): signed 64-bit
// ulong (0 to 18,446,744,073,709,551,615): unsigned 64-bit

using System;

class Program
{
    static void Main()
    {
        ushort first_var = 52130;
        sbyte second_var = -115;
        int third_var = 4825932;
        byte forth_var = 97;
        short fifth_var = -10000;

    }
}

