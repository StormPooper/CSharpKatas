using System.Collections.Generic;

namespace BowlingKata
{
    public class Scoreboard
    {
        private const int NumberOfFrames = 10;
        private const int Strike = 10;

        private readonly IList<int> _pins = new List<int>();

        public int CalculateScore()
        {
            var score = 0;
            var currentRole = 0;

            for (var i = 0; i < NumberOfFrames; i++)
            {
                if (_pins[currentRole] == Strike)
                {
                    score += _pins[currentRole] + _pins[currentRole + 1] + _pins[currentRole + 2];
                    currentRole++;
                }
                else
                {
                    score += _pins[currentRole] + _pins[currentRole + 1];
                    currentRole += 2;
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