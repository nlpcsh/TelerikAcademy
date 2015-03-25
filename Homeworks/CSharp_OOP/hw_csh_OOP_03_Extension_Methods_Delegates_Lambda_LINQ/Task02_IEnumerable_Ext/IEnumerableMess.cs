using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02_IEnumerable_Ext
{
    class IEnumerableMess
    {
        static void Main()
        {
            IEnumerable<int> someCollection = new List<int>() { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("Initial collection is:");
            foreach (var item in someCollection)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();

            Console.WriteLine("Sum of elements is: {0}", someCollection.SumOfElements());
            Console.WriteLine("Product of elements is: {0}", someCollection.ProductOfElements());
            Console.WriteLine("Max element is: {0}", someCollection.MaxOfElements());
            Console.WriteLine("Min element is: {0}", someCollection.MinOfElements());
            Console.WriteLine("Average value is: {0}", someCollection.AverageOfElements());

        }
    }
}
