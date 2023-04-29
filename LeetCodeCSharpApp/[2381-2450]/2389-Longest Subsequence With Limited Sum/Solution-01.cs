namespace LeetCodeCSharpApp.LongestSubsequenceWithLimitedSum01;

public class Solution
{
    public int[] AnswerQueries(int[] nums, int[] queries)
    {
        Array.Sort(nums);
        int n = nums.Length, m = queries.Length;
        var result = new int[m];

        for (var i = 1; i < n; ++i)
            nums[i] += nums[i - 1];

        for (var i = 0; i < m; ++i)
        {
            var j = Array.BinarySearch(nums, queries[i]);
            result[i] = Math.Abs(j + 1);
        }

        return result;
    }
}
