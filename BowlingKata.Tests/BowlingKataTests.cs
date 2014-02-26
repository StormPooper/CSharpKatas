using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
