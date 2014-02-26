using System.Text;

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
            var numerals = new StringBuilder(roman.ToUpper());
            var result = 0;

            result = AddValueForNumeral(numerals, "VI", 6, result);
            result = AddValueForNumeral(numerals, "V", 5, result);
            result = AddValueForNumeral(numerals, "IV", 4, result);
            while(numerals.Length > 0)
            {
                result = AddValueForNumeral(numerals, "I", 1, result);
            }
            return result;
        }

        private static int AddValueForNumeral(StringBuilder numerals, string numeral, int value, int result)
        {
            if (numerals.ToString().StartsWith(numeral))
            {
                result += value;
                numerals.Remove(0, numeral.Length);
            }
            return result;
        }
    }
}