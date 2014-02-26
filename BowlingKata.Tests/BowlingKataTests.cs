using NUnit.Framework;

namespace BowlingKata.Tests
{
    [TestFixture]
    public class BowlingKataTests
    {
        private Scoreboard _scoreboard;

        [SetUp]
        public void CreateScoreboard()
        {
            _scoreboard = new Scoreboard();
        }

        [Test]
        public void AllRollsScore0_TotalScore0()
        {
            RollTwiceForNumberOfFrames(0, 0, 10);
            Assert.AreEqual(0, _scoreboard.CalculateScore());
        }

        [Test]
        public void AllRollsScore1_TotalScore20()
        {
            RollTwiceForNumberOfFrames(1, 1, 10);
            Assert.AreEqual(20, _scoreboard.CalculateScore());
        }

        [Test]
        public void AllFramesScore9_TotalScore90()
        {
            RollTwiceForNumberOfFrames(5, 4, 10);
            Assert.AreEqual(90, _scoreboard.CalculateScore());
        }

        [Test]
        public void StrikeInFirstFrameAndScore2InEachFrameAfter_TotalScore30()
        {
            RollStrikeForNumberOfFrames(1);
            RollTwiceForNumberOfFrames(1, 1, 9);
            Assert.AreEqual(30, _scoreboard.CalculateScore());
        }

        [Test]
        public void StrikeInEveryFrame_TotalScore300()
        {
            RollStrikeForNumberOfFrames(10);
            RollTwiceForNumberOfFrames(10, 10, 1);
            Assert.AreEqual(300, _scoreboard.CalculateScore());
        }

        private void RollStrikeForNumberOfFrames(int numberOfFrames)
        {
            for (var i = 0; i < numberOfFrames; i++)
            {
                _scoreboard.Roll(10);
            }
        }

        private void RollTwiceForNumberOfFrames(int first, int second, int numberOfFrames)
        {
            for (var i = 0; i < numberOfFrames; i++)
            {
                _scoreboard.Roll(first);
                _scoreboard.Roll(second);
            }
        }
    }
}
