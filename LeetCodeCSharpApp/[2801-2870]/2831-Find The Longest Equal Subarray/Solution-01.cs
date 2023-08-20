namespace LeetCodeCSharpApp.FindTheLongestEqualSubarray01;

public class Solution
{
    public int LongestEqualSubarray(IList<int> nums, int k)
    {
        int max = 0, i = 0, n = nums.Count;
        var count = new Dictionary<int, int>();

        for (var j = 0; j < n; j++)
        {
            if (!count.ContainsKey(nums[j]))
                count[nums[j]] = 0;

            count[nums[j]]++;
            max = Math.Max(max, count[nums[j]]);

            if (j - i + 1 - max <= k)
                continue;

            count[nums[i]]--;
            i++;
        }

        return max;
    }
}
