using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;


class GreedyDwarf
{
    static void Main()
    {
        int[] valley = Console.ReadLine()
                          .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                          .Select(int.Parse)
                          .ToArray();
        int M = int.Parse(Console.ReadLine());

        long maxSum = long.MinValue;
        long currentSum = 0;
        bool isOutOfValley = false;
        var stepsMade = new List<int>();

        for (int i = 0; i < M; i++)
        {
            int currentPlaceInValley = 0;
            int[] stepsInValley = Console.ReadLine()
                          .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                          .Select(int.Parse)
                          .ToArray();

            currentSum = valley[0];    // first element aways present
            stepsMade.Add(0);         // first element aways present
            //int stepsCounter = 0;

            while (!isOutOfValley)
            {
                foreach (var step in stepsInValley)
                {
                    currentPlaceInValley += step;

                    if ((currentPlaceInValley > valley.Length - 1) || (currentPlaceInValley <= 0) || stepsMade.Exists(x => x == currentPlaceInValley))
                    {
                        //stepsMade.Clear();
                        isOutOfValley = true;
                        break;
                    }

                    currentSum += valley[currentPlaceInValley];

                    stepsMade.Add(currentPlaceInValley);
                }
            }
            if (currentSum > maxSum)
            {
                maxSum = currentSum;
            }
            isOutOfValley = false;
            stepsMade.Clear();
        }
        Console.WriteLine(maxSum);
    }
}

