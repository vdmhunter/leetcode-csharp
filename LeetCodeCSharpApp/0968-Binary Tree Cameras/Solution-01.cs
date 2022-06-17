using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.BinaryTreeCameras01;

public class Solution
{
    public int MinCameraCover(TreeNode root)
    {
        var ans = Solve(root);
        return Math.Min(ans[1], ans[2]);
    }

    private static int[] Solve(TreeNode node)
    {
        if (node == null)
            return new[] { 0, 0, 99999 };

        var l = Solve(node.left);
        var r = Solve(node.right);
        var mL12 = Math.Min(l[1], l[2]);
        var mR12 = Math.Min(r[1], r[2]);

        var d0 = l[1] + r[1];
        var d1 = Math.Min(l[2] + mR12, r[2] + mL12);
        var d2 = 1 + Math.Min(l[0], mL12) + Math.Min(r[0], mR12);

        return new[] { d0, d1, d2 };
    }
}
