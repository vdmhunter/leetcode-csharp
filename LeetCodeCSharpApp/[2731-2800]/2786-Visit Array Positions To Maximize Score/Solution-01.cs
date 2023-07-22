namespace LeetCodeCSharpApp.VisitArrayPositionsToMaximizeScore01;

public class Solution
{
    public long MaxScore(int[] nums, int x)
    {
        long even = nums[0] - (nums[0] % 2 == 1 ? x : 0);
        long odd = nums[0] - (nums[0] % 2 == 1 ? 0 : x);

        for (var i = 1; i < nums.Length; ++i)
            if (nums[i] % 2 == 1)
                odd = nums[i] + Math.Max(odd, even - x);
            else
                even = nums[i] + Math.Max(even, odd - x);

        return Math.Max(even, odd);
    }
}
