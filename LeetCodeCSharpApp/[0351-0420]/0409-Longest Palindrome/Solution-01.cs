namespace LeetCodeCSharpApp.LongestPalindrome01;

public class Solution
{
    public int LongestPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s))
            return 0;

        var hs = new HashSet<char>();
        var count = 0;

        foreach (var c in s)
            if (hs.Contains(c))
            {
                hs.Remove(c);
                count++;
            }
            else
                hs.Add(c);

        if (hs.Count != 0)
            return count * 2 + 1;

        return count * 2;
    }
}
