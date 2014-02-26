using NUnit.Framework;

namespace RomanKata.Tests
{
    [TestFixture]
    public class RomanKataTests
    {
        private NumberConverter _converter;

        [TestFixtureSetUp]
        public void NumberConverterSetup()
        {
            _converter = new NumberConverter();
        }

        [Test]
        public void One_Becomes_I()
        {
            const int number = 1;
            var romanNumerals = _converter.ToRomanNumeral(number);
            Assert.AreEqual("I", romanNumerals);
        }

        [Test]
        public void Two_Becomes_II()
        {
            const int number = 2;
            var result = _converter.ToRomanNumeral(number);
            Assert.AreEqual("II", result);
        }

        [Test]
        public void Three_Becomes_III()
        {
            const int number = 3;
            var result = _converter.ToRomanNumeral(number);
            Assert.AreEqual("III", result);
        }
    }
}