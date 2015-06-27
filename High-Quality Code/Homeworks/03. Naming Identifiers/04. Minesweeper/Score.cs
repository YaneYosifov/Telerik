namespace Minesweeper
{
    public class Score
    {
        private string name;
        private int playerPoints;

        public Score(string name, int playerPoints)
        {
            this.name = name;
            this.playerPoints = playerPoints;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Points
        {
            get { return this.playerPoints; }
            set { this.playerPoints = value; }
        }
    }
}
