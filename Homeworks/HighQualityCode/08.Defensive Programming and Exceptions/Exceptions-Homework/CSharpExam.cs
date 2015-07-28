namespace ExceprionsHW
{
    using System;

    public class CSharpExam : Exam
    {
        private int score;

        public CSharpExam(int score)
        {
            this.Score = score;
        }

        public int Score
        {
            get
            {
                return this.score;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The score cannot be negative!");
                }

                this.score = value;
            }
        }

        public override ExamResult Check()
        {
            if (this.Score < 0 || this.Score > 100)
            {
                throw new ArgumentOutOfRangeException("The score should in the range from 0 to 100, including.");
            }
            else
            {
                return new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
            }
        }
    }
}