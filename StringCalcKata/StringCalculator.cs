using System;
using System.Linq;
using System.Text;

namespace StringCalcKata
{
    public class StringCalculator
    {
        private static readonly string[] DefaultDelimiters = { ",", "\n" };

        public int Add(string sum)
        {
            if (sum == string.Empty) return 0;
            var calculation = new StringBuilder(sum);
            var delimiter = Delimiter(calculation);
            var total = 0;
            foreach (var value in calculation.ToString().Split(delimiter, StringSplitOptions.None).Select(number => Convert.ToInt32(number)))
            {
                if(value < 0) throw new ArgumentOutOfRangeException(sum, "Negatives are not allowed.");
                if(value > 1000) continue;
                total += value;
            }
            return total;
        }

        private static string[] Delimiter(StringBuilder sum)
        {
            var calculation = sum.ToString();
            if (!calculation.StartsWith("//")) return DefaultDelimiters;
            var delimiter = new[] { calculation.Split(new[] {"\n"}, StringSplitOptions.None).First().Remove(0, 2) };
            sum.Remove(0, 3 + delimiter[0].Length);
            return delimiter;
        }
    }
}