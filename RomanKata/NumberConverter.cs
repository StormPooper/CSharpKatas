namespace RomanKata
{
    public class NumberConverter
    {
        public string ToRomanNumeral(int numberToConvert)
        {
            if (numberToConvert == 2) return "II";
            return "I";
        }
    }
}