namespace LeetCodeCSharpApp.FurthestBuildingYouCanReach02;

/// <summary>
/// Binary Search | O(n log n)
/// </summary>
public class Solution
{
    public int FurthestBuilding(int[] heights, int bricks, int ladders)
    {
        var n = heights.Length;
        var diffs = new int[n][];
        diffs[0] = new[] { 0, 0 }; // diffs (floored at 0) with original index

        for (var i = 1; i < n; i++)
            diffs[i] = new[] { i, Math.Max(heights[i] - heights[i - 1], 0) };

        // largest diffs first
        Array.Sort(diffs, (a, b) => b[1] - a[1]);

        int ans = 0, l = 1, r = n - 1;
        while (l <= r)
        {
            var mid = (l + r) / 2;

            // use ladders for the largest diffs with index<=mid
            var usedBricks = 0;

            for (int i = 0, lads = ladders; i < n; i++)
                if (diffs[i][0] <= mid)
                {
                    if (lads > 0) lads--;
                    else usedBricks += diffs[i][1];
                }

            if (usedBricks <= bricks)
            {
                ans = mid;
                l = mid + 1;
            }
            else
                r = mid - 1;
        }

        return ans;
    }
}
