using System;
using System.Linq;

namespace StringCalcKata
{
    public class StringCalculator
    {
        public int Add(string sum)
        {
            if (sum == string.Empty) return 0;
            var delimiter = SetDelimiter(ref sum);
            var total = 0;
            foreach (var value in sum.Split(delimiter).Select(number => Convert.ToInt32(number)))
            {
                if(value < 0) throw new ArgumentOutOfRangeException(sum, "Negatives are not allowed.");
                total += value;
            }
            return total;
        }

        private static char[] SetDelimiter(ref string sum)
        {
            var separator = new[] {',', '\n'};
            if (sum.StartsWith("//"))
            {
                separator = sum.ToCharArray(2, 1);
                sum = sum.Remove(0, 4);
            }
            return separator;
        }
    }
}