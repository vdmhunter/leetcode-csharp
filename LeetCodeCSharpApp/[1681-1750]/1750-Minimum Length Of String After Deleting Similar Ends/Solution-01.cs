namespace LeetCodeCSharpApp.MinimumLengthOfStringAfterDeletingSimilarEnds01;

/// <summary>
///   Two Pointers. Iterative
///
///   Time complexity: O(N)
///   Space complexity: O(1)
/// </summary>
public class Solution
{
    public int MinimumLength(string s)
    {
        int begin = 0, end = s.Length - 1;

        while (begin < end && s[begin] == s[end])
        {
            char ch = s[begin];

            while (begin <= end && s[begin] == ch)
                begin++;

            while (end > begin && s[end] == ch)
                end--;
        }

        return end - begin + 1;
    }
}
