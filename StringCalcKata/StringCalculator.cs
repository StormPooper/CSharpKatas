using System;
using System.Linq;

namespace StringCalcKata
{
    public class StringCalculator
    {
        public int Add(string sum)
        {
            if (sum == string.Empty) return 0;
            var total = 0;
            foreach (var number in sum.Split(','))
            {
                total += Convert.ToInt32(number);
            }
            return total;
        }
    }
}