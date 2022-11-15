using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.CountCompleteTreeNodes02;

public class Solution
{
    public int CountNodes(TreeNode root)
    {
        if (root == null!)
            return 0;

        TreeNode left = root, right = root;
        var height = 0;

        while (right != null!)
        {
            left = left.left;
            right = right.right;
            height++;
        }

        if (left == null!)
            return (1 << height) - 1;

        return 1 + CountNodes(root.left) + CountNodes(root.right);
    }
}
