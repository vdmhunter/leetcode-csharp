using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.FlattenBinaryTreeToLinkedList01;

public class Solution
{
    private TreeNode? _prev;

    public void Flatten(TreeNode root)
    {
        if (root == null)
            return;

        Flatten(root.right);
        Flatten(root.left);

        root.right = _prev!;
        root.left = null!;
        _prev = root;
    }
}
