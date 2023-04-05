namespace LeetCodeCSharpApp.MinimizeMaximumOfArray02;

public class Solution
{
    public int MinimizeArrayValue(int[] nums)
    {
        return (int)Enumerable.Range(0, nums.Length).Aggregate((sum: 0L, res: 0L), (a, i) =>
            (a.sum + nums[i], Math.Max(a.res, (long)Math.Ceiling((decimal)(a.sum + nums[i]) / (i + 1))))).res;
    }
}
