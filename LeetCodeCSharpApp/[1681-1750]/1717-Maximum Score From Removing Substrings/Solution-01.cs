using System.Text;

namespace LeetCodeCSharpApp.MaximumScoreFromRemovingSubstrings01;

public class Solution
{
    public int MaximumGain(string s, int x, int y)
    {
        var sb = new StringBuilder(s);

        (string top, int topScore, string bottom, int bottomScore) = y > x
            ? ("ba", y, "ab", x)
            : ("ab", x, "ba", y);

        return RemovePairs(sb, top) * topScore + RemovePairs(sb, bottom) * bottomScore;
    }

    private static int RemovePairs(StringBuilder s, string target)
    {
        int idx = 0, count = 0;

        foreach (char ch in s.ToString())
        {
            s[idx++] = ch;

            if (idx < 2 || s[idx - 1] != target[1] || s[idx - 2] != target[0])
                continue;

            count++;
            idx -= 2;
        }

        s.Length = idx;

        return count;
    }
}
