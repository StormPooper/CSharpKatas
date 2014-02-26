namespace RomanKata
{
    public class NumberConverter
    {
        public string ToRomanNumeral(int numberToConvert)
        {
            var result = string.Empty;
            for (var i = 0; i < numberToConvert; i++)
            {
                result += "I";
            }
            return result;
        }
    }
}