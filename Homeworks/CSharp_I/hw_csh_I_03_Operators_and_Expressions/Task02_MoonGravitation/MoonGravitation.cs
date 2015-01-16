// Task 2 - The gravitational field of the Moon is approximately 17% of that on the Earth.
//  Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

using System;

namespace Task02_MoonGravitation
{
    class MoonGravitation
    {
        static void Main()
        {
            Console.Write(" Enter weight of a man (in kg) on Earth: ");
            float manEarthWeight = float.Parse(Console.ReadLine());

            Console.WriteLine(" Weight on the Moon will be: {0}", manEarthWeight * 0.17);
        }
    }
}
