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

        [Test]
        public void EmptyString_Total0()
        {
            var result = Calculator.Add(string.Empty);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void One_One_TotalTwo()
        {
            var result = Calculator.Add("1,1");
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Two_Two_TotalFour()
        {
            var result = Calculator.Add("2,2");
            Assert.AreEqual(4, result);
        }
    }
}