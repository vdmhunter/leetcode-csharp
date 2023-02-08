namespace LeetCodeCSharpApp.JumpGameII01;

public class Solution
{
    public int Jump(int[] nums)
    {
        var current = 0;
        var farthest = 0;
        var jump = 0;

        for (var i = 0; i < nums.Length - 1; i++)
        {
            farthest = Math.Max(farthest, nums[i] + i);

            if (i != current)
                continue;
            
            current = farthest;
            jump++;
        }

        return jump;
    }
}
