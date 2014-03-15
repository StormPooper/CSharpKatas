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

        [TestCase("Man, that is a sweet car.")]
        [TestCase("Man, that is a sweet ass car.")]
        [TestCase("Man, that is a sweetass car.")]
        public void SentenceDoesNotContainHyphenAss_HyphenIsNotMoved(string sentence)
        {
            Assert.AreEqual(sentence, sentence.MoveHyphen());
        }

        [Test]
        public void SentenceStartsWithHyphenAss_HyphenIsNotMoved()
        {
            const string sentence = "-ass car";
            Assert.AreEqual(sentence, sentence.MoveHyphen());
        }
    }
}