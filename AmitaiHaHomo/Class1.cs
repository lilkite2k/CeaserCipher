public static class StringExtensions
{
    public static bool IsAWord(this string text)
    {
        var regex = new Regex(@"\b[\w']+\b");
        var match = regex.Match(text);
        return match.Success;
    }
}
