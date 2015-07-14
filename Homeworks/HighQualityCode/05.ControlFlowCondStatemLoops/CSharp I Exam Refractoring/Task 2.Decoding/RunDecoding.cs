namespace Task_2.Decoding
{
    using System.Text;
    
    internal class RunDecoding
    {
        internal static void Main()
        {
            Decoder currentDecoder = new Decoder();

            float[] result = currentDecoder.DecodingTextLineByLine();

            PrintResult(result);
        }

        private static void PrintResult(float[] result)
        {
            StringBuilder resultString = new StringBuilder();

            for (int i = 0; i < result.Length; i++)
            {
                if (i % 2 == 0)
                {
                    resultString.Append(result[i].ToString("F2"));
                }
                else
                {
                    resultString.Append(result[i].ToString());
                }

                if (i != result.Length - 1)
                {
                    resultString.Append(System.Environment.NewLine);
                }
            }

            System.Console.WriteLine(resultString.ToString());
        }
    }
}
