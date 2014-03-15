using System.Text.RegularExpressions;

namespace SweetAssKata
{
    public static class StringExtension
    {
        private const string WordToMoveHyphenAround = "ass";

        public static string MoveHyphen(this string sentence)
        {
            const string beforeHyphenatedWord = "-" + WordToMoveHyphenAround + " ";
            const string afterHyphenatedWord = " " + WordToMoveHyphenAround + "-";
            var match = Regex.Match(sentence, @"[^\s]+"  + beforeHyphenatedWord + @"[^\s]+");
            return match.Success
                ? sentence.Replace(beforeHyphenatedWord, afterHyphenatedWord)
                : sentence;
        }
    }
}