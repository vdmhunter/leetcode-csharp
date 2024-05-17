using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.DeleteLeavesWithAGivenValue01;

public class Solution
{
    public TreeNode RemoveLeafNodes(TreeNode root, int target)
    {
        if (root == null!)
            return null!;

        root.left = RemoveLeafNodes(root.left, target);
        root.right = RemoveLeafNodes(root.right, target);

        if (root.left != null! || root.right != null! || root.val != target)
            return root;

        return null!;
    }
}
