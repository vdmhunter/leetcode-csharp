namespace LeetCodeCSharpApp.ShortestPalindrome01;

public class Solution
{
    public string ShortestPalindrome(string s)
    {
        var left = 0;

        for (int right = s.Length - 1; right >= 0; right--)
            if (s[left] == s[right])
                left++;

        if (left == s.Length)
            return s;

        string suffix = s[left..];
        var prefix = new string(suffix.Reverse().ToArray());
        string mid = ShortestPalindrome(s[..left]);

        return prefix + mid + suffix;
    }
}
