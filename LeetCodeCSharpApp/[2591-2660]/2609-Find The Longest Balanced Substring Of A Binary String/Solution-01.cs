namespace LeetCodeCSharpApp.FindTheLongestBalancedSubstringOfABinaryString01;

public class Solution
{
    public int FindTheLongestBalancedSubstring(string s)
    {
        var result = 0;

        for (var i = 0; i < s.Length; i++)
        {
            for (var j = i; j < s.Length; j++)
            {
                var substr = s.Substring(i, j - i + 1);
                var len = substr.Length;

                if (len % 2 == 0 &&
                    substr[..(len / 2)].All(c => c == '0') &&
                    substr[(len / 2)..].All(c => c == '1'))
                {
                    result = Math.Max(result, j - i + 1);
                }
            }
        }

        return result;
    }
}
