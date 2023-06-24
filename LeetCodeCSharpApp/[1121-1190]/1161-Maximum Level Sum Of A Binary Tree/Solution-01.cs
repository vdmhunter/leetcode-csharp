using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.MaximumLevelSumOfABinaryTree01;

public class Solution
{
    public int MaxLevelSum(TreeNode root)
    {
        if (root is null)
            return 0;

        var minLevel = 0;
        var level = 0;
        var maxSum = int.MinValue;

        var q = new Queue<TreeNode>();
        q.Enqueue(root);

        while (q.Count > 0)
        {
            level++;
            var levelSize = q.Count;
            var sum = 0;

            sum = SumLevelNodes(q, levelSize, sum);

            if (sum <= maxSum)
                continue;

            maxSum = sum;
            minLevel = level;
        }

        return minLevel;
    }

    private static int SumLevelNodes(Queue<TreeNode> q, int levelSize, int sum)
    {
        while (levelSize-- > 0)
        {
            var node = q.Dequeue();
            sum += node.val;
            EnqueueChildren(q, node);
        }

        return sum;
    }

    private static void EnqueueChildren(Queue<TreeNode> q, TreeNode node)
    {
        if (node.left is not null)
            q.Enqueue(node.left);

        if (node.right is not null)
            q.Enqueue(node.right);
    }
}
