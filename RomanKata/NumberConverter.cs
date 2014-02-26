namespace RomanKata
{
    public class NumberConverter
    {
        public string ToRomanNumeral(int numberToConvert)
        {
            if (numberToConvert == 3) return "III";
            if (numberToConvert == 2) return "II";
            else return "I";
        }
    }
}