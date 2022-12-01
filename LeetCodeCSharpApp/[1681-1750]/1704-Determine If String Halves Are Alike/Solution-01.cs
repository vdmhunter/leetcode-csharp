namespace LeetCodeCSharpApp.DetermineIfStringHalvesAreAlike01;

public class Solution
{
    public bool HalvesAreAlike(string s)
    {
        HashSet<char> vowels = new("aeiouAEIOU");

        var mid = s.Length / 2;
        var a = s[..mid].Count(c => vowels.Contains(c));
        var b = s[mid..].Count(c => vowels.Contains(c));

        return a == b;
    }
}
