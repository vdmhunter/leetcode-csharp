using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.MaximumWidthOfBinaryTree01;

public class Solution
{
    public int WidthOfBinaryTree(TreeNode root)
    {
        int levelOld = 1, numOld = 1, maxWidth = 0;

        var queue = new Queue<(int, int, TreeNode)>();
        queue.Enqueue((levelOld, numOld, root));

        while (queue.Count > 0)
        {
            var (num, level, node) = queue.Dequeue();

            if (level > levelOld)
            {
                levelOld = level;
                numOld = num;
            }

            maxWidth = Math.Max(maxWidth, num - numOld + 1);

            if (node.left != null)
                queue.Enqueue((num * 2, level + 1, node.left));

            if (node.right != null)
                queue.Enqueue((num * 2 + 1, level + 1, node.right));
        }

        return maxWidth;
    }
}
