using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.MaximumDifferenceBetweenNodeAndAncestor01;

public class Solution
{
    public int MaxAncestorDiff(TreeNode root)
    {
        return DoTheThing(root, root.val, root.val);
    }

    private static int DoTheThing(TreeNode node, int min, int max)
    {
        if (node is null)
            return max - min;

        min = Math.Min(min, node.val);
        max = Math.Max(max, node.val);

        return Math.Max(DoTheThing(node.left, min, max), DoTheThing(node.right, min, max));
    }
}
