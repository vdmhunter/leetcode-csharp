using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.ConstructBinaryTreeFromPreorderAndInorderTraversal01;

public class Solution
{
    public TreeNode BuildTree(int[] preorder, int[] inorder)
    {
        return preorder.Length != inorder.Length
            ? null!
            : Build(preorder, 0, preorder.Length - 1, inorder, 0, inorder.Length - 1);
    }

    private static TreeNode Build(int[] preorder, int preLow, int preHigh, int[] inorder, int inLow, int inHigh)
    {
        if (preLow > preHigh || inLow > inHigh)
            return null!;

        var root = new TreeNode(preorder[preLow]);
        var inorderRoot = inLow;

        for (var i = inLow; i <= inHigh; i++)
            if (inorder[i] == root.val)
            {
                inorderRoot = i;

                break;
            }

        var leftTreeLength = inorderRoot - inLow;

        root.left = Build(preorder, preLow + 1, preLow + leftTreeLength, inorder, inLow, inorderRoot - 1);
        root.right = Build(preorder, preLow + leftTreeLength + 1, preHigh, inorder, inorderRoot + 1, inHigh);

        return root;
    }
}
