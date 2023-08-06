namespace LeetCodeCSharpApp.MaximumEleganceOfAKLengthSubsequence01;

public class Solution
{
    public long FindMaximumElegance(int[][] items, int k)
    {
        Array.Sort(items, (a, b) => b[0] - a[0]);

        var result = 0L;
        var cur = 0L;
        var dup = new List<int>();
        var seen = new HashSet<int>();

        for (var i = 0; i < items.Length; i++)
        {
            if (UpdateCurAndDup(i))
                break;

            seen.Add(items[i][1]);
            result = Math.Max(result, cur + (long)seen.Count * seen.Count);
        }

        return result;

        #region UpdateCurAndDup

        bool UpdateCurAndDup(int i)
        {
            if (i < k)
            {
                if (seen.Contains(items[i][1]))
                    dup.Add(items[i][0]);

                cur += items[i][0];
            }
            else if (!seen.Contains(items[i][1]))
            {
                if (dup.Count == 0)
                    return true;

                cur += items[i][0] - dup[^1];
                dup.RemoveAt(dup.Count - 1);
            }

            return false;
        }

        #endregion
    }
}
