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
