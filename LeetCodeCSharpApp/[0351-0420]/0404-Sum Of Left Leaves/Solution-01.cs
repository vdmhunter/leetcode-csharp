using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.SumOfLeftLeaves01;

public class Solution
{
    public int SumOfLeftLeaves(TreeNode root)
    {
        return Traverse(root, false);
    }

    private int Traverse(TreeNode node, bool left)
    {
        if (node == null)
            return 0;

        if (node.left == null && node.right == null)
            return left ? node.val : 0;

        return Traverse(node.left!, true) + Traverse(node.right, false);
    }
}
