using System.Text;

namespace RomanKata
{
    public class NumberConverter
    {
        private readonly int[] _values = { 40, 10, 9, 5, 4, 1 };
        private readonly string[] _numerals = { "XL", "X", "IX", "V", "IV", "I" };

        public string ToRomanNumeral(int number)
        {
            var result = new StringBuilder();
            var remaining = number;
            for (var i = 0; i < _values.Length; i++)
            {
                remaining = AppendHighestRomanNumeral(remaining, _values[i], _numerals[i], result);   
            }
            return result.ToString();
        }

        private static int AppendHighestRomanNumeral(int remaining, int value, string numeral, StringBuilder numerals)
        {
            var result = remaining;
            while (result >= value)
            {
                numerals.Append(numeral);
                result -= value;
            }
            return result;
        }
    }
}