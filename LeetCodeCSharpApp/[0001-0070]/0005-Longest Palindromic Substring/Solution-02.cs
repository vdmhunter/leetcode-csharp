namespace LeetCodeCSharpApp.LongestPalindromicSubstring02;

public class Solution
{
    public string LongestPalindrome(string s)
    {
        int start = 0, end = 0;

        for (var i = 0; i < s.Length; i++)
        {
            var odd = Expand(s, i, i);
            var even = Expand(s, i, i + 1);
            var len = Math.Max(odd, even);

            if (len <= end - start)
                continue;

            start = i - (len - 1) / 2;
            end = i + len / 2;
        }

        return s[start .. (end + 1)];
    }

    private static int Expand(string s, int left, int right)
    {
        while (left >= 0 && right < s.Length && s[left] == s[right])
        {
            left--;
            right++;
        }

        return right - left - 1;
    }
}
