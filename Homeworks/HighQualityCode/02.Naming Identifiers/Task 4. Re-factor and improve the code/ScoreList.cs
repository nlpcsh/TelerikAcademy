namespace MineSweeperGame
{
    internal class Score
    {
        private string name;
        private int playerScore;

        public Score()
        {
        }

        public Score(string name, int score)
        {
            this.Name = name;
            this.PlayerScore = score;
        }

        public string Name
        {
            get 
            { 
                return this.name; 
            }

            set 
            { 
                this.name = value; 
            }
        }

        public int PlayerScore
        {
            get 
            { 
                return this.playerScore; 
            }

            set 
            { 
                this.playerScore = value; 
            }
        }
    }
}
