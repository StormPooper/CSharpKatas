using System;
using System.Linq;

namespace StringCalcKata
{
    public class StringCalculator
    {
        public int Add(string sum)
        {
            if (sum == string.Empty) return 0;
            var first = sum.Split(',').First();
            var second = sum.Split(',').Last();
            return Convert.ToInt32(first) + Convert.ToInt32(second);
        }
    }
}