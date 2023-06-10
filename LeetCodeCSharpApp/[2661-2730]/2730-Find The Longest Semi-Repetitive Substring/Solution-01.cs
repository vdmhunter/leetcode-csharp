namespace LeetCodeCSharpApp.FindTheLongestSemiRepetitiveSubstring01;

public class Solution
{
    public int LongestSemiRepetitiveSubstring(string s)
    {
        int result = 1, i = 0, j = 1, last = 0;

        while (j < s.Length)
        {
            if (s[j] == s[j - 1])
            {
                if (last != 0)
                    i = last;

                last = j;
            }

            result = Math.Max(result, j - i + 1);
            j++;
        }

        return result;
    }
}
