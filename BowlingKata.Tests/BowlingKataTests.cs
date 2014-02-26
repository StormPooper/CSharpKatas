using NUnit.Framework;

namespace BowlingKata.Tests
{
    [TestFixture]
    public class BowlingKataTests
    {
        [Test]
        public void AllRollsScore0_TotalScore0()
        {
            var scoreboard = new Scoreboard();
            Assert.AreEqual(0, scoreboard.CalculateScore());
        }

        [Test]
        public void AllRollsScore1_TotalScore20()
        {
            var scoreboard = new Scoreboard();
            for (var i = 0; i < 20; i++)
            {
                scoreboard.Roll(1);
            }
            Assert.AreEqual(20, scoreboard.CalculateScore());
        }
    }
}
