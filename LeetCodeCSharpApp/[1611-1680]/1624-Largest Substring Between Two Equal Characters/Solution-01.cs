namespace LeetCodeCSharpApp.LargestSubstringBetweenTwoEqualCharacters01;

public class Solution
{
    public int MaxLengthBetweenEqualCharacters(string s)
    {
        var firstOccurrence = new int[26];

        for (var i = 0; i < 26; i++)
            firstOccurrence[i] = -1;

        var maxLen = -1;

        for (var i = 0; i < s.Length; i++)
            if (firstOccurrence[s[i] - 'a'] == -1)
                firstOccurrence[s[i] - 'a'] = i;
            else
                maxLen = Math.Max(maxLen, i - firstOccurrence[s[i] - 'a'] - 1);

        return maxLen;
    }
}
