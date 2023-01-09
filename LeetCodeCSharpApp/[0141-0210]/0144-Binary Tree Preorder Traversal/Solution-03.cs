using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.BinaryTreePreorderTraversal03;

/// <summary>
/// Morris Traversal
/// </summary>
public class Solution
{
    public IList<int> PreorderTraversal(TreeNode root)
    {
        var result = new List<int>();
        var curr = root;

        while (curr != null)
            // If there is no left child, go for the right child.
            // Otherwise, find the last node in the left subtree. 
            if (curr.left == null)
            {
                result.Add(curr.val);
                curr = curr.right;
            }
            else
            {
                var last = curr.left;
                
                while (last.right != null && last.right != curr)
                    last = last.right;

                // If the last node is not modified, we let 
                // 'curr' be its right child. Otherwise, it means we 
                // have finished visiting the entire left subtree.
                if (last.right == null)
                {
                    result.Add(curr.val);
                    last.right = curr;
                    curr = curr.left;
                }
                else
                {
                    last.right = null!;
                    curr = curr.right;
                }
            }

        return result;
    }
}
