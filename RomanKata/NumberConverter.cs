using System.Text;

namespace RomanKata
{
    public class NumberConverter
    {
        private readonly int[] _values = { 10, 9, 5, 4 };
        private readonly string[] _numerals = { "X", "IX", "V", "IV" };

        public string ToRomanNumeral(int number)
        {
            var remaining = number;
            var result = new StringBuilder();

            for (var i = 0; i < remaining; i++)
            {
                remaining = AppendHighestRomanNumeral(remaining, _values[i], _numerals[i], result);   
            }
            AddRemainingNumerals(remaining, result);

            return result.ToString();
        }

        private static void AddRemainingNumerals(int remaining, StringBuilder result)
        {
            for (var i = 0; i < remaining; i++)
            {
                result.Append("I");
            }
        }

        private static int AppendHighestRomanNumeral(int remaining, int value, string numeral, StringBuilder result)
        {
            if (remaining >= value)
            {
                result.Append(numeral);
                remaining -= value;
            }
            return remaining;
        }
    }
}