namespace LeetCodeCSharpApp.DivideArrayIntoArraysWithMaxDifference02;

public class Solution
{
    public int[][] DivideArray(int[] nums, int k)
    {
        Array.Sort(nums);

        var result = new int[nums.Length / 3][];
        var index = 0;

        for (var i = 0; i < nums.Length; i += 3)
        {
            if (nums[i + 2] - nums[i] <= k)
            {
                result[index] = [nums[i], nums[i + 1], nums[i + 2]];
                index++;
            }
            else
            {
                return Array.Empty<int[]>();
            }
        }

        return result;
    }
}
