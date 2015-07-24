namespace CSharp2Exam
{
    using System;
    using System.Text;

    internal class EnigmaCat
    {
        public static void Main()
        {
            var words = Console.ReadLine().Split(' ');

            foreach (var word in words)
            {
                // 17 to ulong
                ulong numInDec = ConvertWordToSeventeenNumeralSystem(word);

                // ulong to 26
                StringBuilder sb = ConvertUlongToTwentySixNumeralSystem(numInDec);

                Console.Write(sb.ToString() + " ");
            }

            Console.WriteLine();
        }

        private static StringBuilder ConvertUlongToTwentySixNumeralSystem(ulong numInDec)
        {
            var sb = new StringBuilder();

            while (numInDec > 0)
            {
                sb.Insert(0, (char)((numInDec % 26) + 'a'));
                numInDec /= 26;
            }

            return sb;
        }

        private static ulong ConvertWordToSeventeenNumeralSystem(string word)
        {
            ulong numInDec = 0;

            for (int i = 0; i < word.Length; i++)
            {
                numInDec *= 17;
                numInDec += (ulong)(word[i] - 'a');
            }

            return numInDec;
        }
    }
}