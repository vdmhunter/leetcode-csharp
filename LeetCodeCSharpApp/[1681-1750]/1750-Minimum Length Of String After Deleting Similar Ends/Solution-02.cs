namespace LeetCodeCSharpApp.MinimumLengthOfStringAfterDeletingSimilarEnds02;

/// <summary>
///   Two Pointers. Tail Recursion
///
///   Time complexity: O(N)
///   Space complexity: O(1)
/// </summary>
public class Solution
{
    public int MinimumLength(string s)
    {
        return DeleteSimilarEnds(s, 0, s.Length - 1);
    }

    private static int DeleteSimilarEnds(string s, int begin, int end)
    {
        if (begin >= end || s[begin] != s[end])
            return end - begin + 1;

        char ch = s[begin];

        while (begin <= end && s[begin] == ch)
            begin++;

        while (end > begin && s[end] == ch)
            end--;

        return DeleteSimilarEnds(s, begin, end);
    }
}
