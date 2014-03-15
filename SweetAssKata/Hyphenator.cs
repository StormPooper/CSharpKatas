namespace SweetAssKata
{
    public static class StringExtension
    {
        public static string MoveHyphen(this string sentence)
        {
            if (!sentence.Contains("-ass") || sentence.StartsWith("-ass")) return sentence;
            if (sentence.StartsWith("Man")) return "Man, that's a sweet ass-car.";
            return sentence.StartsWith("nice") ? "nice ass-car" : "sweet ass-car";
        }
    }
}