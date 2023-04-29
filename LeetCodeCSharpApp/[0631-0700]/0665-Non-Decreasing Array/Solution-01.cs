namespace LeetCodeCSharpApp.NonDecreasingArray01;

public class Solution
{
    public bool CheckPossibility(int[] nums)
    {
        var check = false;

        for (var i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] <= nums[i + 1])
                continue;

            if (check || (i > 0 && i < nums.Length - 2 && nums[i + 2] < nums[i] && nums[i - 1] > nums[i + 1]))
                return false;

            check = true;
        }

        return true;
    }
}
