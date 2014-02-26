using System.Collections.Generic;

namespace BowlingKata
{
    public class Scoreboard
    {
        private readonly IList<int> _pins = new List<int>();
        public int CalculateScore()
        {
            var score = 0;

            for (var i = 0; i < _pins.Count; i++)
            {
                if (_pins[i] == 10)
                {
                    score += _pins[i] + _pins[i + 1] + _pins[i + 2];
                }
                else
                {
                    score += _pins[i];
                }
            }

            return score;
        }

        public void Roll(int pins)
        {
            _pins.Add(pins);
        }
    }
}