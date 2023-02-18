using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.MinimumDistanceBetweenBSTNodes01;

public class Solution
{
    public int MinDiffInBST(TreeNode root)
    {
        var min = int.MaxValue;
        var prev = int.MinValue;
        MinDiffInBST(root, ref min, ref prev);

        return min;
    }

    private static void MinDiffInBST(TreeNode root, ref int min, ref int prev)
    {
        if (root == null)
            return;

        MinDiffInBST(root.left, ref min, ref prev);

        if (prev != int.MinValue)
            min = Math.Min(min, root.val - prev);

        prev = root.val;
        MinDiffInBST(root.right, ref min, ref prev);
    }
}

public class Solution1
{
    public int MinimizeSum(int[] nums)
    {
        var n = nums.Length;
        Array.Sort(nums);

        return new[] { nums[n - 1] - nums[0], nums[n - 1] - nums[2], nums[n - 3] - nums[0], nums[n - 2] - nums[1] }.Min();
    }
}
