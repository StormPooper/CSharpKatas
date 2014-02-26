using NUnit.Framework;

namespace RomanKata.Tests
{
    [TestFixture]
    public class RomanKataTests
    {
        [Test]
        public void One_Becomes_I()
        {
            const int numberToConvert = 1;
            var converter = new NumberConverter();

            var result = converter.ToRomanNumeral(numberToConvert);

            Assert.AreEqual("I", result);
        }

        [Test]
        public void Two_Becomes_II()
        {
            const int numberToConvert = 2;
            var converter = new NumberConverter();

            var result = converter.ToRomanNumeral(numberToConvert);

            Assert.AreEqual("II", result);
        }
    }
}