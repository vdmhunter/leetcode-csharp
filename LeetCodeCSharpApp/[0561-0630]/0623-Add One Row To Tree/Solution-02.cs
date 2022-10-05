using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.AddOneRowToTree02;

public class Solution
{
    public TreeNode AddOneRow(TreeNode root, int val, int depth)
    {
        if (root == null!)
            return null!;

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        
        if (depth == 1)
            return new TreeNode(val) { left = root };

        var level = 0;
        
        while (queue.Count > 0)
        {
            var n = queue.Count;
            level += 1;
            
            for (var i = 0; i < n; i++)
            {
                if (level > depth)
                    return root;

                ProcessNode(queue.Dequeue());
            }
        }

        void ProcessNode(TreeNode node)
        {
            EnqueueNodeIfNotNull(node.left);
            EnqueueNodeIfNotNull(node.right);

            if (level != depth - 1)
                return;

            var newLeftNode = new TreeNode(val);
            var newRightNode = new TreeNode(val);

            newLeftNode.left = node.left;
            newRightNode.right = node.right;

            node.left = newLeftNode;
            node.right = newRightNode;
        }

        void EnqueueNodeIfNotNull(TreeNode node)
        {
            if (node != null!)
                queue.Enqueue(node);
        }
        
        return root;
    }
}
