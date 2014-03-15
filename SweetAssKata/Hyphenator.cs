using System.Text.RegularExpressions;

namespace SweetAssKata
{
    public static class StringExtension
    {
        private const string BeforeHyphenatedWord = "-ass ";
        private const string AfterHyphenatedWord = " ass-";

        public static string MoveHyphen(this string sentence)
        {
            var match = Regex.Match(sentence, @"[^\s]+"  + BeforeHyphenatedWord + @"[^\s]+");
            if (!match.Success) return sentence;
            return sentence.Replace(BeforeHyphenatedWord, AfterHyphenatedWord);
        }
    }
}