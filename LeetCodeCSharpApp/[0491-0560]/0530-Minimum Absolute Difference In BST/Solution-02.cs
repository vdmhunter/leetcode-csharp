using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.MinimumAbsoluteDifferenceInBST02;

public class Solution
{
    public int GetMinimumDifference(TreeNode root)
    {
        int[] arr = { -1, int.MaxValue };
        Inorder(root, arr);

        return arr[1];
    }

    private static void Inorder(TreeNode root, int[] arr)
    {
        if (root == null)
            return;

        Inorder(root.left, arr);

        if (arr[0] != -1)
            arr[1] = Math.Min(arr[1], Math.Abs(arr[0] - root.val));

        arr[0] = root.val;

        Inorder(root.right, arr);
    }
}
