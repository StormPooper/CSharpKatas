using System;
using System.Linq;

namespace StringCalcKata
{
    public class StringCalculator
    {
        public int Add(string sum)
        {
            if (sum == string.Empty) return 0;
            var separator = new []{ ',', '\n' };
            if (sum.StartsWith("//"))
            {
                separator = sum.ToCharArray(2, 1);
                sum = sum.Remove(0, 4);
            }
            return sum.Split(separator).Sum(number => Convert.ToInt32(number));
        }
    }
}