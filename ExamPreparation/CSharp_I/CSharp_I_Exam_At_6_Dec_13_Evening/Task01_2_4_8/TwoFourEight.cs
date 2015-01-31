using System;

class TwoFourEight
{
    static void Main()
    {
        //Console.Write(" Enter first Number");
        ulong A = ulong.Parse(Console.ReadLine());
        //Console.Write(" Enter second Number");
        ulong B = ulong.Parse(Console.ReadLine());
        //Console.Write(" Enter third Number");
        ulong C = ulong.Parse(Console.ReadLine());

        ulong R = 0;

        switch (B)
        {
            case 2:
                R = A % C;
                break;
            case 4:
                R = A + C;
                break;
            case 8:
                R = A * C;
                break;
            default:
                break;
        }

        if (R % 4 == 0)
        {
            Console.WriteLine(R / 4);
        }
        else
        {
            Console.WriteLine(R % 4);   
        }
        Console.WriteLine(R);
    }
}

