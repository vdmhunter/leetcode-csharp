namespace LeetCodeCSharpApp.LeftAndRightSumDifferences01;

public class Solution
{
    // ReSharper disable once IdentifierTypo
    public int[] LeftRigthDifference(int[] nums)
    {
        var n = nums.Length;
        var leftSum = new int[n];
        var rightSum = new int[n];
        var result = new int[n];

        // Calculate the prefix sums for left and right arrays
        for (var i = 1; i < n; i++)
            leftSum[i] = leftSum[i - 1] + nums[i - 1];

        for (var i = n - 2; i >= 0; i--)
            rightSum[i] = rightSum[i + 1] + nums[i + 1];

        // Calculate the answer array using left and right sums
        for (var i = 0; i < n; i++)
            result[i] = Math.Abs(leftSum[i] - rightSum[i]);

        return result;
    }
}
