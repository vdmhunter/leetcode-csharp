using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.ConstructBinaryTreeFromInorderAndPostorderTraversal01;

public class Solution
{
    public TreeNode BuildTree(int[] inorder, int[] postorder)
    {
        if (postorder.Length == 0 || inorder.Length == 0)
            return null!;

        var pos = Array.IndexOf(inorder, postorder[^1]);

        return new TreeNode(postorder[^1])
        {
            left = BuildTree(inorder[..pos], postorder[..pos]),
            right = BuildTree(inorder[(pos + 1)..], postorder[pos..^1])
        };
    }
}
