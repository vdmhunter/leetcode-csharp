namespace LeetCodeCSharpApp.MaximumNumberOfNonOverlappingPalindromeSubstrings01;

public class Solution
{
    public int MaxPalindromes(string s, int k)
    {
        var result = 0;
        var n = s.Length;
        var last = int.MinValue;
        var intervals = new List<IList<int>>();

        for (var center = 0; center < 2 * n; center++)
        {
            var left = center / 2;
            var right = left + center % 2;

            FillIntervals(left, right);
        }

        foreach (var v in intervals)
        {
            if (v[0] >= last)
            {
                last = v[1];
                result++;
            }
            else if (v[1] < last)
            {
                last = v[1];
            }
        }

        #region FillIntervals

        void FillIntervals(int l, int r)
        {
            while (l >= 0 && r < n && s[l] == s[r])
            {
                if (r + 1 - l >= k)
                {
                    intervals.Add(new List<int> { l, r + 1 });

                    break;
                }

                l--;
                r++;
            }
        }

        #endregion

        return result;
    }
}
