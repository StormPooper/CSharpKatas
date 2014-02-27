using System;
using System.Linq;

namespace StringCalcKata
{
    public class StringCalculator
    {
        public int Add(string sum)
        {
            return sum == string.Empty
                ? 0
                : sum.Split(new []{ ',', '\n' }).Sum(number => Convert.ToInt32(number));
        }
    }
}