namespace LeetCodeCSharpApp.SumOfDistances01;

public class Solution
{
    public long[] Distance(int[] nums)
    {
        var n = nums.Length;
        var result = new long[n];
        var mp = new Dictionary<int, List<int>>();

        for (var i = 0; i < n; i++)
        {
            if (!mp.ContainsKey(nums[i]))
                mp[nums[i]] = new List<int>();

            mp[nums[i]].Add(i);
        }

        foreach (var (_, indexes) in mp)
        {
            var totalSum = indexes.Aggregate<int, long>(0, (current, index) => current + index);
            var preSum = 0L;

            for (var i = 0; i < indexes.Count; i++)
            {
                var index = indexes[i];
                var postSum = totalSum - preSum - index;
                result[index] += index * (long)i;
                result[index] -= preSum;
                result[index] -= index * (long)(indexes.Count - i - 1);
                result[index] += postSum;
                preSum += index;
            }
        }

        return result;
    }
}
