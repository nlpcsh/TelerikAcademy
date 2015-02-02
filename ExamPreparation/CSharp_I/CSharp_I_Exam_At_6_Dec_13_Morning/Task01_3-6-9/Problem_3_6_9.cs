using System;

class Problem_3_6_9
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
            case 9:
                R = A % C;
                break;
            case 3:
                R = A + C;
                break;
            case 6:
                R = A * C;
                break;
            default:
                break;
        }

        if (R % 3 == 0)
        {
            Console.WriteLine(R / 3);
        }
        else
        {
            Console.WriteLine(R % 3);
        }
        Console.WriteLine(R);
    }
}


