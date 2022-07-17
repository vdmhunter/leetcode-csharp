using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.MaximumDepthOfBinaryTree01;

public class Solution
{
    public int MaxDepth(TreeNode root)
    {
        // Base Condition
        if (root == null)
            return 0;

        // Hypothesis
        var left = MaxDepth(root.left);
        var right = MaxDepth(root.right);

        // Induction
        return Math.Max(left, right) + 1;
    }
}
