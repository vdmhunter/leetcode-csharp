using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.CountCompleteTreeNodes03;

public class Solution
{
    public int CountNodes(TreeNode root)
    {
        if (root == null!)
            return 0;

        return 1 + CountNodes(root.left) + CountNodes(root.right);
    }
}
