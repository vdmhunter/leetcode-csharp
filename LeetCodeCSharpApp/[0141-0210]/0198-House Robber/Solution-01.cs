namespace LeetCodeCSharpApp.HouseRobber01;

public class Solution
{
    public int Rob(int[] nums)
    {
        if (nums.Length == 0)
            return 0;

        var prev1 = 0;
        var prev2 = 0;

        foreach (var num in nums)
        {
            var tmp = prev1;
            prev1 = Math.Max(prev2 + num, prev1);
            prev2 = tmp;
        }

        return prev1;
    }
}
