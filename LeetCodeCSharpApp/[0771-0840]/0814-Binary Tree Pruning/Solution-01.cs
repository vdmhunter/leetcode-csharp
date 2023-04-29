using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.BinaryTreePruning01;

public class Solution
{
    public TreeNode PruneTree(TreeNode root)
    {
        if (root == null)
            return root!;

        root.left = PruneTree(root.left);
        root.right = PruneTree(root.right);

        if (root.left != null || root.right != null)
            return root;

        if (root.val == 0)
            root = null!;

        return root;
    }
}
