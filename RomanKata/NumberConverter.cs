namespace RomanKata
{
    public class NumberConverter
    {
        public string ToRomanNumeral(int number)
        {
            var left = number;
            var result = string.Empty;

            if (left > 8)
            {
                result = "IX";
                left -= 9;
            }if (left > 4)
            {
                result = "V";
                left -= 5;
            }
            if (left > 3)
            {
                result = "IV";
                left -= 4;
            }
            for (var i = 0; i < left; i++)
            {
                result += "I";
            }

            return result;
        }
    }
}