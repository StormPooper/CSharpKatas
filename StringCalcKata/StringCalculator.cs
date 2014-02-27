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
            return sum.Split(delimiter).Sum(number => Convert.ToInt32(number));
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