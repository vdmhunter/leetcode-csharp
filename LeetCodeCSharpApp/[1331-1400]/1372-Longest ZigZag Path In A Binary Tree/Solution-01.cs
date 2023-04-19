using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.LongestZigZagPathInABinaryTree01;

public class Solution
{
    public int LongestZigZag(TreeNode root)
    {
        return Dfs(root)[2];
    }

    private static int[] Dfs(TreeNode root)
    {
        if (root == null)
            return new[] { -1, -1, -1 };

        int[] left = Dfs(root.left), right = Dfs(root.right);
        var result = Math.Max(Math.Max(left[1], right[0]) + 1, Math.Max(left[2], right[2]));

        return new[] { left[1] + 1, right[0] + 1, result };
    }
}
