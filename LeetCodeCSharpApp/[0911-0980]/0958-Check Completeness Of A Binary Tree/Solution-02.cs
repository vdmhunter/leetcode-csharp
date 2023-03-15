using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.CheckCompletenessOfABinaryTree02;

public class Solution
{
    public bool IsCompleteTree(TreeNode root) => Check(root).valid;

    private static (int max, int min, bool valid) Check(TreeNode root)
    {
        if (root is null)
            return (0, 0, true);

        var left = Check(root.left);
        var right = Check(root.right);

        return (left.max + 1, right.min + 1,
            left.valid && right.valid && left.min >= right.max && left.max <= right.min + 1);
    }
}
