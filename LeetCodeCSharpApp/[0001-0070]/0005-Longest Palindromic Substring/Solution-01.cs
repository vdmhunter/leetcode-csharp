using System.Text;

namespace LeetCodeCSharpApp.LongestPalindromicSubstring01;

public class Solution
{
    public string LongestPalindrome(string s)
    {
        var sb = PrepareString(s);
        var palindromeRadii = new int[sb.Length];
        var center = 0;
        var radius = 0;

        for (var i = 0; i < sb.Length; i++)
        {
            var mirror = 2 * center - i;

            if (i < radius)
                palindromeRadii[i] = Math.Min(radius - i, palindromeRadii[mirror]);

            UpdatePalindromeRadius(sb, palindromeRadii, i);

            if (i + palindromeRadii[i] <= radius)
                continue;

            center = i;
            radius = i + palindromeRadii[i];
        }

        return ExtractLongestPalindrome(s, palindromeRadii);
    }

    private static StringBuilder PrepareString(string s)
    {
        var sb = new StringBuilder("#");

        foreach (var c in s)
            sb.Append(c).Append('#');

        return sb;
    }

    private static void UpdatePalindromeRadius(StringBuilder sb, int[] palindromeRadii, int i)
    {
        while (CanExpandPalindrome(sb, palindromeRadii, i))
            palindromeRadii[i]++;
    }

    private static bool CanExpandPalindrome(StringBuilder sb, int[] palindromeRadii, int i)
    {
        return i + 1 + palindromeRadii[i] < sb.Length
               && i - 1 - palindromeRadii[i] >= 0
               && sb[i + 1 + palindromeRadii[i]] == sb[i - 1 - palindromeRadii[i]];
    }

    private static string ExtractLongestPalindrome(string s, int[] palindromeRadii)
    {
        var maxLength = 0;
        var centerIndex = 0;

        for (var i = 0; i < palindromeRadii.Length; i++)
        {
            if (palindromeRadii[i] <= maxLength)
                continue;

            maxLength = palindromeRadii[i];
            centerIndex = i;
        }

        var startIndex = (centerIndex - maxLength) / 2;

        return s.Substring(startIndex, maxLength);
    }
}
