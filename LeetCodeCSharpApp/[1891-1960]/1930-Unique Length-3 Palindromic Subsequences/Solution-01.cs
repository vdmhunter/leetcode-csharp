namespace LeetCodeCSharpApp.UniqueLength3PalindromicSubsequences01;

public class Solution
{
    public int CountPalindromicSubsequence(string s)
    {
        var result = 0;

        var first = new int[26];
        var last = new int[26];

        Array.Fill(first, int.MaxValue);

        for (var i = 0; i < s.Length; ++i)
        {
            first[s[i] - 'a'] = Math.Min(first[s[i] - 'a'], i);
            last[s[i] - 'a'] = i;
        }

        for (var i = 0; i < 26; ++i)
            if (first[i] < last[i])
                result += s.Substring(first[i] + 1, last[i] - first[i] - 1).Distinct().Count();

        return result;
    }
}
