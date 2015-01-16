// Task 8 - rite a program that prints an isosceles triangle of 9 copyright symbols ©.

using System;

class IsoscelesTriangle
{
    static void Main()
    {

        // Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("   \u00A9");
        Console.WriteLine(" ");
        Console.WriteLine("  \u00A9 \u00A9");
        Console.WriteLine(" ");
        Console.WriteLine(" \u00A9   \u00A9");
        Console.WriteLine(" ");
        Console.WriteLine("\u00A9 \u00A9 \u00A9 \u00A9");
    }
}


