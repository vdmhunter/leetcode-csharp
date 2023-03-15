using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.CheckCompletenessOfABinaryTree01;

public class Solution
{
    public bool IsCompleteTree(TreeNode root)
    {
        var bfs = new Queue<TreeNode>();
        bfs.Enqueue(root);

        while (bfs.Any())
        {
            var node = bfs.Dequeue();

            if (node == null)
                return bfs.All(x => x == null);

            bfs.Enqueue(node.left);
            bfs.Enqueue(node.right);
        }

        return false;
    }
}
