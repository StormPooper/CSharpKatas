﻿using System.Collections.Generic;

namespace BowlingKata
{
    public class Scoreboard
    {
        private const int NumberOfFrames = 10;
        private const int MaximumScoreForFrame = 10;

        private readonly IList<int> _pins = new List<int>();
        private int _currentRoll;

        public int CalculateScore()
        {
            var score = 0;
            _currentRoll = 0;
            for (var i = 0; i < NumberOfFrames; i++)
            {
                if (RolledAStrike(_currentRoll))
                    score = ScoreStrike(score);
                else if (RolledASpare(_currentRoll))
                    score = ScoreSpare(score);
                else
                    score = ScoreNormalFrame(score);
            }
            return score;  
        }

        private int ScoreStrike(int score)
        {
            score += _pins[_currentRoll] + _pins[_currentRoll + 1] + _pins[_currentRoll + 2];
            _currentRoll++;
            return score;
        }

        private int ScoreSpare(int score)
        {
            score += _pins[_currentRoll] + _pins[_currentRoll + 1] + _pins[_currentRoll + 2];
            _currentRoll += 2;
            return score;
        }

        private int ScoreNormalFrame(int score)
        {
            score += _pins[_currentRoll] + _pins[_currentRoll + 1];
            _currentRoll += 2;
            return score;
        }

        private bool RolledASpare(int currentRoll)
        {
            return _pins[currentRoll] + _pins[currentRoll + 1] == MaximumScoreForFrame;
        }

        private bool RolledAStrike(int currentRoll)
        {
            return _pins[currentRoll] == MaximumScoreForFrame;
        }

        public void Roll(int pins)
        {
            _pins.Add(pins);
        }
    }
}