namespace LeetCodeCSharpApp.LargestElementInAnArrayAfterMergeOperations01;

public class Solution
{
    public long MaxArrayValue(int[] nums)
    {
        var n = nums.Length;
        var sum = (long)nums[n - 1];
        var result = sum;

        for (var i = nums.Length - 2; i >= 0; i--)
        {
            if (nums[i] <= sum)
                sum += nums[i];
            else
                sum = nums[i];

            result = Math.Max(result, sum);
        }

        return result;
    }
}

