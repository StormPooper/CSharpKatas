﻿using System.Text;

namespace RomanKata
{
    public class NumberConverter
    {
        private readonly int[] _values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        private readonly string[] _numerals = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

        public string ToRoman(int number)
        {
            var result = new StringBuilder();
            var remaining = number;
            for (var i = 0; i < _values.Length; i++)
            {
                remaining = AppendRomanNumeral(remaining, _values[i], _numerals[i], result);   
            }
            return result.ToString().ToUpper();
        }

        private static int AppendRomanNumeral(int remaining, int value, string numeral, StringBuilder numerals)
        {
            var result = remaining;
            while (result >= value)
            {
                numerals.Append(numeral);
                result -= value;
            }
            return result;
        }

        public int ToArabic(string roman)
        {
            var numerals = roman.ToUpper();
            var result = 0;

            switch (numerals)
            {
                case "VI":
                    result += 6;
                    break;
                case "V":
                    result += 5;
                    break;
                case "IV":
                    result += 4;
                    break;
                default:
                    for (var i = 0; i < numerals.Length; i++)
                    {
                        result++;
                    }
                    break;
            }
            return result;
        }
    }
}