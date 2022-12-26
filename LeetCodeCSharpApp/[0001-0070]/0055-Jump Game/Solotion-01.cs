namespace LeetCodeCSharpApp.JumpGame01;

public class Solution
{
    public bool CanJump(int[] nums)
    {
        var reachable = 0;

        for (var i = 0; i < nums.Length; ++i)
        {
            if (i > reachable)
                return false;

            reachable = Math.Max(reachable, i + nums[i]);
        }

        return true;
    }
}
