namespace Strategy
{
    using System.Collections.Generic;

    public class SortDescending : ISorter
    {
        public void Sort(List<int> list)
        {
            list.Sort((first, second) => second.CompareTo(first));
        }
    }
}
