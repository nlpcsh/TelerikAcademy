
namespace Task03_Range_Exceptions
{
    using System;

    class InvalidRangeException<T> : ApplicationException
    {
        private T start;
        private T end;

        public T End
        {
            get { return end; }
            set { end = value; }
        }

        public T Start
        {
            get { return start; }
            private set { start = value; }
        }


        public InvalidRangeException(T start, T end)
        {
            this.Start = start;
            this.End = end;
        }

        public override string Message
        {
            get
            {
                return string.Format(" is out of the range [{0}, {1}]", this.Start, this.End);
            }
        }

    }
}
