namespace Task_2.Decoding
{
    /// <summary>
    /// Decodes input text by given rules for each character of it
    /// </summary>
    internal class Decoder
    {
        // codding number
        private byte salt;
        private string inputText;
        private short toAdd = 500;
        private byte coefficient = 100;

        public string InputText
        {
            get 
            { 
                return this.inputText; 
            }

            set
            {
                if (value == null)
                {
                    throw new System.Exception("Input string is empty!");
                }

                this.inputText = value;
            }
        }

        public string Salt
        {
            get
            {
                return this.salt.ToString();
            }

            set
            {
                try
                {
                    this.salt = byte.Parse(value);
                }
                catch (System.FormatException)
                {
                    throw new System.FormatException("The input is not number between 1 and 10!");
                }
            }
        }

        internal float[] DecodingTextLineByLine()
        {
            this.Salt = System.Console.ReadLine();

            this.InputText = System.Console.ReadLine();

            short position = 0;

            // Length is shorter because of the "end" character of the string
            float[] result = new float[this.InputText.Length - 1];

            foreach (char c in this.InputText)
            {
                if (c == '@' || position >= this.InputText.Length - 1)
                {
                    return result;
                }

                if (((c >= 'a') && (c <= 'z')) || ((c >= 'A') && (c <= 'Z')))
                {
                    result[position] = (c * this.salt) + this.toAdd + this.toAdd;
                }
                else if ((c >= '0') && (c <= '9'))
                {
                    result[position] = c + this.salt + this.toAdd;
                }
                else
                {
                    result[position] = c - this.salt;
                }

                if (position % 2 == 0)
                {
                    result[position] /= this.coefficient;
                }
                else
                {
                    result[position] *= this.coefficient;
                }

                position++;
            }

            return result;
        }
    }
}
