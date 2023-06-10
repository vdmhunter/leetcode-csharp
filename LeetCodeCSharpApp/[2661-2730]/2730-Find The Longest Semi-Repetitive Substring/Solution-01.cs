namespace LeetCodeCSharpApp.FindTheLongestSemiRepetitiveSubstring01;

public class Solution
{
    public int LongestSemiRepetitiveSubstring(string s)
    {
        var start = 0;
        var end = 1;
        var maxLen = 0;
        var count = 0;
        var pos = 0;

        while (end < s.Length)
        {
            if (s[end] == s[end - 1])
                if (count == 1)
                {
                    maxLen = Math.Max(maxLen, end - start);
                    start = pos;
                    pos = end;
                }
                else
                {
                    pos = end;
                    count++;
                }

            end++;
        }

        maxLen = Math.Max(maxLen, end - start);

        return maxLen;
    }
}
