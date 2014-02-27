using System;
using System.Linq;
using System.Text;

namespace StringCalcKata
{
    public class StringCalculator
    {
        private static readonly char[] DefaultDelimiters = { ',', '\n' };

        public int Add(string sum)
        {
            if (sum == string.Empty) return 0;
            var calculation = new StringBuilder(sum);
            var delimiter = Delimiter(calculation);
            var total = 0;
            foreach (var value in calculation.ToString().Split(delimiter).Select(number => Convert.ToInt32(number)))
            {
                if(value < 0) throw new ArgumentOutOfRangeException(sum, "Negatives are not allowed.");
                if(value > 1000) continue;
                total += value;
            }
            return total;
        }

        private static char[] Delimiter(StringBuilder sum)
        {
            var calculation = sum.ToString();
            if (!calculation.StartsWith("//")) return DefaultDelimiters;
            var delimiter = calculation.ToCharArray(2, 1);
            sum.Remove(0, 4);
            return delimiter;
        }
    }
}