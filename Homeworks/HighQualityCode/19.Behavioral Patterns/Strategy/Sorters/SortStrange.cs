namespace Strategy
{
    using System.Collections.Generic;

    public class SortStrange : ISorter
    {
        public void Sort(List<int> list)
        {
            list.Sort((first, second) => (first % 3).CompareTo(second % 3));
        }
    }
}
