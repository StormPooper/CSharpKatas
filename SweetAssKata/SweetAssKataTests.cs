using NUnit.Framework;

namespace SweetAssKata
{
    [TestFixture]
    public class SweetAssKataTests
    {
        [Test]
        public void SweetAss_Car_Becomes_Sweet_AssCar()
        {
            var result = Hyphenator.MoveHyphen("sweet-ass car");
            Assert.AreEqual("sweet ass-car", result);
        }

        [Test]
        public void NiceAss_Car_Becomes_Nice_AssCar()
        {
            var result = Hyphenator.MoveHyphen("nice-ass car");
            Assert.AreEqual("nice ass-car", result);
        }

        [Test]
        public void ManThatsASweetAss_Car_Becomes_ManThatsASweet_AssCar()
        {
            var result = Hyphenator.MoveHyphen("Man, that's a sweet-ass car.");
            Assert.AreEqual("Man, that's a sweet ass-car.", result);
        }
    }
}