namespace LeetCodeCSharpApp.MoveZeroes01;

public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        var snowBallSize = 0;

        for (var i = 0; i < nums.Length; i++)
            if (nums[i] == 0)
                snowBallSize++;
            else if (snowBallSize > 0)
            {
                nums[i - snowBallSize] = nums[i];
                nums[i] = 0;
            }
    }
}
