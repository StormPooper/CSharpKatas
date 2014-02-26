namespace BowlingKata
{
    public class Scoreboard
    {
        private int _score;
        public int CalculateScore()
        {
            return _score;
        }

        public void Roll(int pins)
        {
            _score += pins;
        }
    }
}