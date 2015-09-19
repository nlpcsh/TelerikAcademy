namespace Strategy
{
    using System.Collections.Generic;

    public class ArraySorter
    {
        private readonly ISorter sortMethod;
        private List<int> listOfInts;

        public ArraySorter(List<int> list, ISorter sortMethod)
        {
            this.sortMethod = sortMethod;
            this.ListOfInts = list;
        }

        public List<int> ListOfInts
        {
            get
            {
                return this.listOfInts;
            }

            set
            {
                this.listOfInts = value;
            }
        }

        public void SortArray()
        {
            this.sortMethod.Sort(this.ListOfInts);
        }
    }
}
