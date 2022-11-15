using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.CountCompleteTreeNodes01;

public class Solution
{
    public int CountNodes(TreeNode root)
    {
        var h = Height(root);

        return h < 0
            ? 0
            : Height(root.right) == h - 1
                ? (1 << h) + CountNodes(root.right)
                : (1 << (h - 1)) + CountNodes(root.left);
    }

    private static int Height(TreeNode root)
    {
        return root == null! ? -1 : 1 + Height(root.left);
    }
}
