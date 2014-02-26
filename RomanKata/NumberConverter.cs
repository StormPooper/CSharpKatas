namespace RomanKata
{
    public class NumberConverter
    {
        public string ToRomanNumeral(int number)
        {
            var result = string.Empty;

            if (number == 4) result = "IV";
            else {
                for (var i = 0; i < number; i++)
                {
                    result += "I";
                }
            }

            return result;
        }
    }
}