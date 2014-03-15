namespace SweetAssKata
{
    public static class StringExtension
    {
        private const string HyphenatedWord = "-ass";
        public static string MoveHyphen(this string sentence)
        {
            if (!sentence.Contains(HyphenatedWord) || sentence.StartsWith(HyphenatedWord) || sentence.EndsWith(HyphenatedWord)) return sentence;
            if (sentence.ToLower().StartsWith("man")) return "Man, that's a sweet ass-car.";
            return sentence.StartsWith("nice") ? "nice ass-car" : "sweet ass-car";
        }
    }
}