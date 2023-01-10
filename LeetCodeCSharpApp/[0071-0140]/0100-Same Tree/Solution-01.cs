using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.SameTree01;

/// <summary>
/// Recursion
/// </summary>
public class Solution
{
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        if (p == null! && q == null!)
            return true;

        if (p == null! || q == null!)
            return false;

        if (p.val != q.val)
            return false;

        return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
    }
}
