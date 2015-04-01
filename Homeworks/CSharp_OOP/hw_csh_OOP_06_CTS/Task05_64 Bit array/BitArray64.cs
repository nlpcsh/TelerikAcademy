
namespace Task05_64_Bit_array
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    class BitArray64 : IEnumerable<int>
    {
        private ulong variable64;

        public ulong Variable64
        {
            get { return variable64; }
            set { variable64 = value; }
        }
        
        public BitArray64(ulong variable)
        {
            this.Variable64 = variable;
        }

        public int[] BitArray
        {
            get { return this.Convert(this.Variable64 ); }
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= BitArray.Length)
                {
                    throw new IndexOutOfRangeException("No such index");
                }
                return BitArray[index];
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < this.BitArray.Length; i++)
            {
                yield return this.BitArray[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override int GetHashCode()
        {
            return this.Variable64.GetHashCode() ^ 123 ^
                   this.BitArray[5].GetHashCode() ^
                   this.BitArray[25].GetHashCode();
        }

        public static bool operator ==(BitArray64 first, BitArray64 second)
        {
            return first.Equals(second);
        }

        public static bool operator !=(BitArray64 first, BitArray64 second)
        {
            return !first.Equals(second);
        }

        private int[] Convert(ulong value)
        {
            int[] result = new int[64];
            int counter = 63;

            do
            {
                result[counter] = (int)value % 2;
                value /= 2;
                counter--;
            } while (value > 0);

            if (counter > 0)
            {
                for (int i = counter; i >= 0; i--)
                {
                    result[i] = 0;
                }
            }

            return result;
        }

        public override bool Equals(object obj)
        {
            if (obj is BitArray64)
            {
                for (int i = 0; i < this.BitArray.Length; i++)
                {

                    if (this.BitArray[i] != (obj as BitArray64).BitArray[i])
                    {
                        return false;
                    }
                }

                return true;
            }
            if (obj is string)
            {
                var padded = (obj as string).PadLeft(64, '0');

                for (int i = 0; i < padded.Length; i++)
                {
                    if (int.Parse(padded[i].ToString()) != this.BitArray[i])
                    {
                        return false;
                    }
                }

                return true;
            }
            return false;
        }
    }
}
