namespace LeetCodeCSharpApp.MakeStringASubsequenceUsingCyclicIncrements01;

public class Solution
{
    public bool CanMakeSubsequence(string str1, string str2)
    {
        int j = 0, n = str1.Length, m = str2.Length;

        for (var i = 0; i < n && j < m; i++)
        {
            int a = str1[i], b = str2[j];

            if (a == b || a + 1 == b || a - 25 == b)
                j++;
        }

        return j == m;
    }
}
