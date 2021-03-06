﻿using NUnit.Framework;

namespace RomanKata
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
        [TestCase(10, "X")]
        [TestCase(17, "XVII")]
        [TestCase(29, "XXIX")]
        [TestCase(34, "XXXIV")]
        [TestCase(40, "XL")]
        [TestCase(50, "L")]
        [TestCase(64, "LXIV")]
        [TestCase(90, "XC")]
        [TestCase(100, "C")]
        [TestCase(400, "CD")]
        [TestCase(500, "D")]
        [TestCase(900, "CM")]
        [TestCase(1000, "M")]
        [TestCase(1987, "MCMLXXXVII")]
        [TestCase(2014, "MMXIV")]
        [TestCase(3000, "MMM")]
        public void Arabic_To_Roman(int arabic, string expected)
        {
            var result = _converter.ToRoman(arabic);
            Assert.AreEqual(expected.ToUpper(), result);
        }

        [TestCase("I", 1)]
        [TestCase("II", 2)]
        [TestCase("III", 3)]
        [TestCase("IV", 4)]
        [TestCase("V", 5)]
        [TestCase("VI", 6)]
        [TestCase("IX", 9)]
        [TestCase("X", 10)]
        [TestCase("XVII", 17)]
        [TestCase("XXIX", 29)]
        [TestCase("XXXIV", 34)]
        [TestCase("XL", 40)]
        [TestCase("L", 50)]
        [TestCase("LXIV", 64)]
        [TestCase("XC", 90)]
        [TestCase("C", 100)]
        [TestCase("CD", 400)]
        [TestCase("D", 500)]
        [TestCase("CM", 900)]
        [TestCase("M", 1000)]
        [TestCase("MCMLXXXVII", 1987)]
        [TestCase("MMXIV", 2014)]
        [TestCase("MMM", 3000)]
        public void Roman_To_Arabic(string roman, int expected)
        {
            var result = _converter.ToArabic(roman);
            Assert.AreEqual(expected, result);
        }
    }
}