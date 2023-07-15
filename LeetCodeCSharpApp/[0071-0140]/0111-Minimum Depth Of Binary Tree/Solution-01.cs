using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.MinimumDepthOfBinaryTree01;

public class Solution
{
    public int MinDepth(TreeNode root)
    {
        if (root == null)
            return 0;

        if (IsLeafNode(root))
            return 1;

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        root.val = 1;

        while (queue.Count > 0)
        {
            var current = queue.Dequeue();

            if (IsLeafNode(current))
                return current.val;

            UpdateChildNode(current.left, current, queue);
            UpdateChildNode(current.right, current, queue);
        }

        return 0;
    }

    private static bool IsLeafNode(TreeNode node)
    {
        return node is { left: null, right: null };
    }

    private static void UpdateChildNode(TreeNode child, TreeNode parent, Queue<TreeNode> queue)
    {
        if (child == null)
            return;

        child.val = parent.val + 1;
        queue.Enqueue(child);
    }
}
