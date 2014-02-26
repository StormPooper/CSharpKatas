using System.Text;

namespace RomanKata
{
    public class NumberConverter
    {
        public string ToRomanNumeral(int number)
        {
            var remaining = number;
            var result = new StringBuilder();

            remaining = AppendHighestRomanNumeral(remaining, 9, "IX", result);
            remaining = AppendHighestRomanNumeral(remaining, 5, "V", result);
            remaining = AppendHighestRomanNumeral(remaining, 4, "IV", result);
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