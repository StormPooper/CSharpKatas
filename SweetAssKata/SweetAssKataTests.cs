using NUnit.Framework;

namespace SweetAssKata
{
    [TestFixture]
    public class SweetAssKataTests
    {
        [Test]
        public void FirstWordWithHyphenAss_SecondWordGetsHyphen()
        {
            var result = Hyphenator.MoveHyphen("sweet-ass car");
            Assert.AreEqual("sweet ass-car", result);
        }
    }
}