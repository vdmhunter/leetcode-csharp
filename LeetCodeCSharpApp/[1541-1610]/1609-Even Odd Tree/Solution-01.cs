using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.EvenOddTree01;

/// <summary>
///   Breadth-First Search
/// 
///   Time Complexity: O(N)
///   Space Complexity: O(N)
/// </summary>
public class Solution
{
    public bool IsEvenOddTree(TreeNode root)
    {
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        var isEvenLevel = true;

        while (queue.Count > 0)
        {
            if (!IsValidLevel(queue, isEvenLevel))
                return false;

            isEvenLevel = !isEvenLevel;
        }

        return true;
    }

    private static bool IsValidLevel(Queue<TreeNode> queue, bool isEvenLevel)
    {
        int size = queue.Count;
        int prevValue = isEvenLevel ? int.MinValue : int.MaxValue;

        while (size > 0)
        {
            TreeNode currentNode = queue.Dequeue();

            if (!IsValidNode(currentNode, isEvenLevel, prevValue))
                return false;

            prevValue = currentNode.val;

            if (currentNode.left != null)
                queue.Enqueue(currentNode.left);

            if (currentNode.right != null)
                queue.Enqueue(currentNode.right);

            size--;
        }

        return true;
    }

    private static bool IsValidNode(TreeNode node, bool isEvenLevel, int prevValue)
    {
        return (!isEvenLevel || (node.val % 2 != 0 && node.val > prevValue)) &&
               (isEvenLevel || (node.val % 2 != 1 && node.val < prevValue));
    }
}
