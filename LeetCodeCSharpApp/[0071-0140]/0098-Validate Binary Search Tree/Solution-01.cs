// ReSharper disable InconsistentNaming

using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.ValidateBinarySearchTree01;

public class Solution
{
    private int? previousNode;

    public bool IsValidBST(TreeNode root)
    {
        while (true)
        {
            if (root == null!)
                return true;

            if (!IsValidBST(root.left) || root.val <= previousNode)
                return false;

            previousNode = root.val;
            root = root.right;
        }
    }
}
