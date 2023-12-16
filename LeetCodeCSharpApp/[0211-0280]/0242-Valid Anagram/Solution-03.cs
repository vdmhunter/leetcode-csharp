namespace LeetCodeCSharpApp.ValidAnagram03;

public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        return s.OrderBy(ch => ch).SequenceEqual(t.OrderBy(ch => ch));
    }
}
