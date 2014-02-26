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

            while(remaining > 0)
            {
                result.Append("I");
                remaining--;
            }

            return result.ToString();
        }

        private static int AppendHighestRomanNumeral(int remaining, int value, string numeral, StringBuilder result)
        {
            while (remaining >= value)
            {
                result.Append(numeral);
                remaining -= value;
            }
            return remaining;
        }
    }
}