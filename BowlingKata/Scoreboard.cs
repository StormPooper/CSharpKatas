namespace BowlingKata
{
    public class Scoreboard
    {
        private int _totalScore;
        public int CalculateScore()
        {
            return _totalScore;
        }

        public void Roll(int score)
        {
            _totalScore += score;
        }
    }
}