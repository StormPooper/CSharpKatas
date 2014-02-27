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
        [TestCase("4,8", 12)]
        [TestCase("172,28", 200)]
        public void CalculateTwoNumberSum(string sum, int expected)
        {
            var result = Calculator.Add(sum);
            Assert.AreEqual(expected, result);
        }

        [TestCase("2,2,2", 6)]
        [TestCase("8,16,32", 56)]
        [TestCase("8,16,32,64,128", 248)]
        public void CalculateAnyNumberSum(string sum, int expected)
        {
            var result = Calculator.Add(sum);
            Assert.AreEqual(expected, result);
        }
    }
}