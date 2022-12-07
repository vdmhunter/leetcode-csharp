using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.RangeSumOfBST01;

public class Solution
{
    // ReSharper disable once InconsistentNaming
    public int RangeSumBST(TreeNode root, int low, int high)
    {
        if (root == null!)
            return 0;

        return RangeSumBST(root.left, low, high) +
               RangeSumBST(root.right, low, high) +
               (root.val >= low && root.val <= high ? root.val : 0);
    }
}
