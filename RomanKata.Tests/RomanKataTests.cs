﻿using NUnit.Framework;

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

        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(4, "IV")]
        [TestCase(5, "V")]
        [TestCase(6, "VI")]
        [TestCase(9, "IX")]
        public void Number_ConvertedTo_RomanNumeral(int number, string expected)
        {
            var romanNumerals = _converter.ToRomanNumeral(number);
            Assert.AreEqual(expected, romanNumerals);
        }
    }
}