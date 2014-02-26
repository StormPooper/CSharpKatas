using System.Collections.Generic;

namespace BowlingKata
{
    public class Scoreboard
    {
        private const int NumberOfFrames = 10;
        private const int MaxPerFrame = 10;

        private readonly IList<int> _pins = new List<int>();

        public int CalculateScore()
        {
            var score = 0;
            var currentRoll = 0;

            for (var i = 0; i < NumberOfFrames; i++)
            {
                if (_pins[currentRoll] == MaxPerFrame)
                {
                    score += _pins[currentRoll] + _pins[currentRoll + 1] + _pins[currentRoll + 2];
                    currentRoll++;
                }
                else if (_pins[currentRoll] + _pins[currentRoll + 1] == MaxPerFrame)
                {
                    score += _pins[currentRoll] + _pins[currentRoll + 1] + _pins[currentRoll + 2];
                    currentRoll += 2;
                }
                else
                {
                    score += _pins[currentRoll] + _pins[currentRoll + 1];
                    currentRoll += 2;
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