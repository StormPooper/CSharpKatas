using System;
using NUnit.Framework;

namespace SweetAssKata
{
    [TestFixture]
    public class SweetAssKataTests
    {
        private readonly string[] _adjectives = { "sweet", "nice", "cool" };
        private readonly string[] _nouns = { "car", "bike", "train" };

        [TestCase("sweet-ass car", "sweet ass-car")]
        [TestCase("nice-ass car", "nice ass-car")]
        [TestCase("Man, that's a sweet-ass car.", "Man, that's a sweet ass-car.")]
        public void SentenceContainsSomethingAssSomething_HyphenIsMoved(string sentence, string expected)
        {
            var result = sentence.MoveHyphen();
            Assert.AreEqual(expected, result);
        }

        [TestCase("Man, that's a sweet car.")]
        [TestCase("Man, that's a sweet ass car.")]
        [TestCase("Man, that's a sweetass car.")]
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

        [Test]
        public void SentenceEndsWithHyphenAss_HyphenIsNotMoved()
        {
            const string sentence = "sweet-ass";
            Assert.AreEqual(sentence, sentence.MoveHyphen());
        }

        [Test]
        // this test is to force an implementation to be written
        public void SentenceHasRandomAdjectiveAndNoun_HyphenIsMoved()
        {
            var adjective = GetRandomString(_adjectives);
            var noun = GetRandomString(_nouns);
            var sentence = "Man, that's a " + adjective + "-ass " + noun + ".";
            var result = sentence.MoveHyphen();
            Assert.AreEqual("Man, that's a " + adjective + " ass-" + noun + ".", result);
        }

        private string GetRandomString(string[] strings)
        {
            return strings[new Random().Next(strings.Length)];
        }
    }
}