using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.LowestCommonAncestorOfABinarySearchTree01;

public class Solution
{
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        return (root.val - p.val) * (root.val - q.val) < 1
            ? root
            : LowestCommonAncestor(p.val < root.val ? root.left : root.right, p, q);
    }
}
