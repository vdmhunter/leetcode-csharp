using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.TwoSumIVInputIsABst02    ;

public class Solution
{
    private readonly HashSet<int> _values = new();
    
    public bool FindTarget(TreeNode root, int k)
    {
        if (root == null)
            return false;
        
        var nodes = new Queue<TreeNode>();
        nodes.Enqueue(root);
        _values.Add(root.val);
        
        while (nodes.Count > 0)
        {
            var currentNode = nodes.Dequeue();
            
            if (HandleChildNode(currentNode.left))
                return true;
            
            if (HandleChildNode(currentNode.right))
                return true;
        }

        bool HandleChildNode(TreeNode node)
        {
            if (node == null)
                return false;
            
            if (_values.Contains(k - node.val))
                return true;

            nodes.Enqueue(node);
            _values.Add(node.val);

            return false;
        }

        return false;
    }
}
