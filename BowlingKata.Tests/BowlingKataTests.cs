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
            Assert.AreEqual(0, _scoreboard.CalculateScore());
        }

        [Test]
        public void AllRollsScore1_TotalScore20()
        {
            for (var i = 0; i < 20; i++)
            {
                _scoreboard.Roll(1);
            }
            Assert.AreEqual(20, _scoreboard.CalculateScore());
        }

        [Test]
        public void AllFramesScore9_TotalScore90()
        {
            for (var i = 0; i < 10; i++)
            {
                _scoreboard.Roll(5);
                _scoreboard.Roll(4);
            }
            Assert.AreEqual(90, _scoreboard.CalculateScore());
        }
    }
}
