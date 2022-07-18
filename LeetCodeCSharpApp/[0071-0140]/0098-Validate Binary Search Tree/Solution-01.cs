// ReSharper disable InconsistentNaming

using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.ValidateBinarySearchTree01;

public class Solution
{
    public bool IsValidBST(TreeNode root)
    {
        return Help(root, null, null);
    }

    private bool Help(TreeNode p, int? low, int? high)
    {
        if (p == null)
            return true;

        return (low == null || p.val > low) && (high == null || p.val < high) &&
               Help(p.left, low, p.val) && Help(p.right, p.val, high);
    }
}
