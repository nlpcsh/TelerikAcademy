using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


class KaspichanNb
{
    static void Main()
    {

        BigInteger inputNb = new BigInteger();

        inputNb = BigInteger.Parse(Console.ReadLine());


        string[] numberValues = new string[256];


        ushort counter = 0;

        for (char i = 'A'; i <= 'Z'; i++)
        {
            numberValues[counter] = i.ToString();
            counter++;
            //Console.WriteLine(numberValues[counter]);
        }

        for (char i = ('a'); i <= ('i'); i++)
        {
            for (char j = 'A'; j <= ('Z'); j++)
            {
                numberValues[counter] = i.ToString() + j.ToString();
                //Console.WriteLine(numberValues[counter]);
                if (counter == 255)
                {
                    break;
                } 
                counter++;
            }
        }

        ConvertTo256(numberValues, inputNb);
    }

    static void ConvertTo256(string[] numberValues, BigInteger inputNb)
    {
        StringBuilder resultStr = new StringBuilder();

        BigInteger residual = 0;

        do
        {
            residual = inputNb % (BigInteger)256;
            inputNb /= (BigInteger)256;
            resultStr.Insert(0,numberValues[int.Parse(residual.ToString())]);
            
        } 
        while (inputNb > 0);

        Console.WriteLine(resultStr.ToString());  
    }

}

