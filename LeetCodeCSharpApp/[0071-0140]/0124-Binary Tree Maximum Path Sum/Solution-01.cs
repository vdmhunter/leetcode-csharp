using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.BinaryTreeMaximumPathSum01;

public class Solution
{
    private int _maxValue;

    public int MaxPathSum(TreeNode root)
    {
        _maxValue = int.MinValue;
        MaxPathDown(root);

        return _maxValue;
    }

    private int MaxPathDown(TreeNode node)
    {
        if (node == null)
            return 0;

        var left = Math.Max(0, MaxPathDown(node.left));
        var right = Math.Max(0, MaxPathDown(node.right));
        _maxValue = Math.Max(_maxValue, left + right + node.val);

        return Math.Max(left, right) + node.val;
    }
}
