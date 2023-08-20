namespace LeetCodeCSharpApp.MakeStringASubsequenceUsingCyclicIncrements02;

public class Solution
{
    public bool CanMakeSubsequence(string str1, string str2)
    {
        var i = 0;

        foreach (var ch in str1)
        {
            var next = (char)((ch - 'a' + 1) % 26 + 'a');

            if (str2[i] != ch && str2[i] != next)
                continue;

            if (++i == str2.Length)
                return true;
        }

        return false;
    }
}
