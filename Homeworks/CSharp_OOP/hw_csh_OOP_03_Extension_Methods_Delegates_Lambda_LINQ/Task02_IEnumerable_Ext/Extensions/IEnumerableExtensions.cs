
namespace Task02_IEnumerable_Ext
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public static class IEnumerableExtensions
    {
        public static T SumOfElements<T>(this IEnumerable<T> inputCollection)
        {
            T sum = (dynamic) 0;

            foreach (var item in inputCollection)
            {
                sum += (dynamic)item;
            }

            return sum;
        }

        public static T ProductOfElements<T>(this IEnumerable<T> inputCollection)
        {
            T product = (dynamic) 1;

            foreach (var item in inputCollection)
            {
                product *= (dynamic)item;
            }

            return product;
        }

        public static T MinOfElements<T>(this IEnumerable<T> inputCollection) where T : IComparable
        {
            T minValue = inputCollection.ElementAt(0);

            foreach (var item in inputCollection)
            {
                if (item.CompareTo(minValue) < 0)
                {
                    minValue = item;
                }
            }

            return minValue;
        }

        public static T MaxOfElements<T>(this IEnumerable<T> inputCollection) where T : IComparable
        {
            T maxValue = inputCollection.ElementAt(0);

            foreach (var item in inputCollection)
            {
                if (item.CompareTo(maxValue) > 0)
                {
                    maxValue = item;
                }
            }

            return maxValue;
        }

        public static T AverageOfElements<T>(this IEnumerable<T> inputCollection)
        {
            return (dynamic) inputCollection.SumOfElements<T>() / inputCollection.Count<T>();
        }
    }
}
