using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringCalcKata
{
    public class StringCalculator
    {
        private static readonly string[] DefaultDelims = { ",", "\n" };
        private const string DelimStart = "//";
        private const string DelimEnd = "\n";
        private static readonly string[] DelimEnds = { DelimEnd };

        public int Add(string sum)
        {
            if (sum == string.Empty) return 0;
            var calculation = new StringBuilder(sum);
            var total = 0;
            foreach (var number in NumbersFromString(calculation))
            {
                if(number < 0) throw new ArgumentOutOfRangeException(sum, "Negatives are not allowed.");
                if(number > 1000) continue;
                total += number;
            }
            return total;
        }

        private static IEnumerable<int> NumbersFromString(StringBuilder calculation)
        {
            var delimiter = Delimiter(calculation);
            return calculation.ToString().Split(delimiter, StringSplitOptions.None).Select(number => Convert.ToInt32(number));
        }

        private static string[] Delimiter(StringBuilder sum)
        {
            var calculation = sum.ToString();
            if (!calculation.StartsWith(DelimStart)) return DefaultDelims;
            var delimiter = new[] { calculation.Split(DelimEnds, StringSplitOptions.None).First().Remove(0, DelimStart.Length) };
            sum.Remove(0, DelimStart.Length + DelimEnd.Length + delimiter[0].Length);
            return delimiter;
        }
    }
}