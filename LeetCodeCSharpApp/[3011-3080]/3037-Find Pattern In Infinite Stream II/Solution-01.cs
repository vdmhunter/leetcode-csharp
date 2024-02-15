using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.FindPatternInInfiniteStreamII01;

/// <summary>
/// Time Complexity: O(n)
/// Space Complexity: O(m)
/// </summary>
public class Solution
{
    public int FindPattern(InfiniteStream stream, int[] pattern)
    {
        var next = CalculateNextArray(pattern);
        var matchIndex = SearchPattern(stream, pattern, next);

        return matchIndex;
    }

    private static int[] CalculateNextArray(int[] pattern)
    {
        var patternLength = pattern.Length;
        var next = new int[patternLength + 1];
        var j = 0;

        for (var i = 1; i < patternLength; i++)
        {
            while (j > 0 && pattern[i] != pattern[j])
                j = next[j];

            if (pattern[i] == pattern[j])
                j++;

            next[i + 1] = j;
        }

        return next;
    }

    private static int SearchPattern(InfiniteStream stream, int[] pattern, int[] next)
    {
        var patternLength = pattern.Length;
        int matchIndex;
        var j = 0;

        for (var i = 0;; i++)
        {
            var currentElement = stream.Next();

            while (j > 0 && currentElement != pattern[j])
                j = next[j];

            if (currentElement == pattern[j])
                j++;

            if (j != patternLength)
                continue;

            matchIndex = i - patternLength + 1;

            break;
        }

        return matchIndex;
    }
}
