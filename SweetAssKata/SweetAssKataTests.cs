using NUnit.Framework;

namespace SweetAssKata
{
    [TestFixture]
    public class SweetAssKataTests
    {
        [TestCase("sweet-ass car", "sweet ass-car")]
        [TestCase("nice-ass car", "nice ass-car")]
        [TestCase("Man, that's a sweet-ass car.", "Man, that's a sweet ass-car.")]
        public void SentenceContainsSomethingAssSomething_HyphenIsMoved(string sentence, string expected)
        {
            var result = sentence.MoveHyphen();
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void SentenceDoesNotContainAss_HyphenIsNotMoved()
        {
            const string sentence = "Man, that is a sweet car.";
            Assert.AreEqual(sentence, sentence.MoveHyphen());
        }
    }
}