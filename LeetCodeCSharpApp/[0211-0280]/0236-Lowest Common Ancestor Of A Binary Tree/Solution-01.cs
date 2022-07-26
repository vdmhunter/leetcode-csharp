using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.LowestCommonAncestorOfABinaryTree01;

/// <summary>
/// Recursive Approach 01
/// </summary>
public class Solution
{
    private TreeNode _result;

    public Solution()
    {
        // Variable to store LCA node.
        _result = null!;
    }

    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        // Traverse the tree
        RecurseTree(root, p, q);
        return _result;
    }

    private bool RecurseTree(TreeNode currentNode, TreeNode p, TreeNode q)
    {
        // If reached the end of a branch, return false.
        if (currentNode == null!)
            return false;

        // Left Recursion. If left recursion returns true, set left = 1 else 0
        var left = RecurseTree(currentNode.left, p, q) ? 1 : 0;

        // Right Recursion
        var right = RecurseTree(currentNode.right, p, q) ? 1 : 0;

        // If the current node is one of p or q
        var mid = currentNode == p || currentNode == q ? 1 : 0;
        
        // If any two of the flags left, right or mid become True
        if (mid + left + right >= 2)
            _result = currentNode;

        // Return true if any one of the three bool values is True.
        return mid + left + right > 0;
    }
}
