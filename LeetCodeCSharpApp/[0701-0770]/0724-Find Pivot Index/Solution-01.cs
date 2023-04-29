namespace LeetCodeCSharpApp.FindPivotIndex01;

/// <summary>
/// Prefix Sum
/// </summary>
public class Solution
{
    public int PivotIndex(int[] nums)
    {
        int sum = 0, leftSum = 0;
        sum += nums.Sum();

        for (var i = 0; i < nums.Length; ++i)
        {
            if (leftSum == sum - leftSum - nums[i])
                return i;

            leftSum += nums[i];
        }

        return -1;
    }
}
