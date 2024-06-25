using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.BinarySearchTreeToGreaterSumTree01;

public class Solution
{
    private int _sum;

    public TreeNode BstToGst(TreeNode root)
    {
        if (root == null!)
            return root!;

        BstToGst(root.right);
        _sum += root.val;
        root.val = _sum;
        BstToGst(root.left);

        return root;
    }
}
