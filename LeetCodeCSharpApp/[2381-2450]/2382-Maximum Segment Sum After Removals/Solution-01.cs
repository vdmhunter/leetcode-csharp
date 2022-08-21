namespace LeetCodeCSharpApp.MaximumSegmentSumAfterRemovals01;

public class Solution
{
    public long[] MaximumSegmentSum(int[] nums, int[] removeQueries)
    {
        var mp = new Dictionary<int, (long, int)>(removeQueries.Length - 1);
        var cur = 0L;
        var res = new List<long>(nums.Length);

        foreach (var q in removeQueries[1..].Reverse())
        {
            mp.Add(q, (nums[q], 1));
            
            (long rv, int rLen) = mp.TryGetValue(q + 1, out var value) ? value : (0, 0);
            (long lv, int lLen) = mp.TryGetValue(q - 1, out value) ? value : (0, 0);
            
            var total = nums[q] + rv + lv;
            mp[q + rLen] = (total, lLen + rLen + 1);
            mp[q - lLen] = (total, lLen + rLen + 1);

            cur = Math.Max(cur, total);
            res.Add(cur);
        }

        res.Reverse();
        res.Add(0);

        return res.ToArray();
    }
}
