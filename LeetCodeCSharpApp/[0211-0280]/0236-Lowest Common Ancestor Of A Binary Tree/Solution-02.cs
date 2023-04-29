using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.LowestCommonAncestorOfABinaryTree02;

/// <summary>
/// Recursive Approach 02
/// </summary>
public class Solution
{
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        if (root == null! || root == p || root == q)
            return root!;

        var right = LowestCommonAncestor(root.right, p, q);
        var left = LowestCommonAncestor(root.left, p, q);

        if (left != null! && right != null!)
            return root;

        return right ?? left!;
    }
}
