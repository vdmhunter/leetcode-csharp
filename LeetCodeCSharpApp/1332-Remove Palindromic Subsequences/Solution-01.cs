namespace LeetCodeCSharpApp.RemovePalindromicSubsequences01;

public class Solution
{
    public int RemovePalindromeSub(string s)
    {
        var n = s.Length;
        for (var i = 0; i < n / 2; i++)
            if (s[i] != s[n - i - 1])
                return 2;

        return 1;
    }
}