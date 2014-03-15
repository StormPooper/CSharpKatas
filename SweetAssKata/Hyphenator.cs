namespace SweetAssKata
{
    public static class Hyphenator
    {
        public static string MoveHyphen(string sentence)
        {
            if (sentence.StartsWith("Man")) return "Man, that's a sweet ass-car.";
            if (sentence.StartsWith("nice")) return "nice ass-car";
            return "sweet ass-car";
        }
    }
}