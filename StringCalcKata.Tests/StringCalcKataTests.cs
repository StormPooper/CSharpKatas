using NUnit.Framework;

namespace StringCalcKata.Tests
{
    [TestFixture]
    public class StringCalcKataTests
    {
        public StringCalculator Calculator;

        [TestFixtureSetUp]
        public void CreateCalculator()
        {
            Calculator = new StringCalculator();
        }

        [TestCase("", 0)]
        [TestCase("1,1", 2)]
        [TestCase("2,2", 4)]
        public void CalculateAdditionFromString(string sum, int expected)
        {
            var result = Calculator.Add(sum);
            Assert.AreEqual(expected, result);
        }
    }
}