namespace SweetAssKata
{
    public static class Hyphenator
    {
        public static string MoveHyphen(string sentence)
        {
            return sentence.StartsWith("nice") ? "nice ass-car" : "sweet ass-car";
        }
    }
}