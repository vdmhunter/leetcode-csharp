namespace LeetCodeCSharpApp.FindTheLongestBalancedSubstringOfABinaryString03;

public class Solution
{
    public int FindTheLongestBalancedSubstring(string s)
    {
        int c0 = 0, c1 = 0, result = 0;

        foreach (var c in s)
        {
            if (c == '0')
                c0 = c1 != 0 ? 1 : c0 + 1;

            c1 = c == '0' ? 0 : c1 + 1;
            result = Math.Max(result, 2 * Math.Min(c0, c1));
        }

        return result;
    }
}
