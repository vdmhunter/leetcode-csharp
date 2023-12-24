namespace LeetCodeCSharpApp.MinimumChangesToMakeAlternatingBinaryString01;

public class Solution
{
    public int MinOperations(string s)
    {
        int mismatchCount = 0, n = s.Length;

        for (var i = 0; i < n; i++)
            if (s[i] - '0' != i % 2)
                mismatchCount++;

        return Math.Min(mismatchCount, n - mismatchCount);
    }
}
