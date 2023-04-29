namespace LeetCodeCSharpApp.MaximumSumWithExactlyKElements01;

public class Solution
{
    public int MaximizeSum(int[] nums, int k)
    {
        Array.Sort(nums);
        Array.Reverse(nums);
        var result = 0;

        for (var i = 0; i < k; i++)
        {
            var m = nums[0];
            nums[0] = m + 1;
            result += m;
            Array.Sort(nums);
            Array.Reverse(nums);
        }

        return result;
    }
}
