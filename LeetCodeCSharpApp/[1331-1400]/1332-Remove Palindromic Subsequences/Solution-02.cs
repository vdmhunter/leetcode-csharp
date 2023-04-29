namespace LeetCodeCSharpApp.RemovePalindromicSubsequences02;

public class Solution
{
    public int RemovePalindromeSub(string s)
    {
        if (string.IsNullOrEmpty(s))
            return 0;

        var r = new string(s.ToCharArray().Reverse().ToArray());
        return s == r ? 1 : 2;
    }
}
