using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.BinaryTreeInorderTraversal02;

public class Solution
{
    public IList<int> InorderTraversal(TreeNode root)
    {
        var result = new List<int>();
        InorderTraversal(root, result);
        
        return result;
    }

    private void InorderTraversal(TreeNode root, List<int> list)
    {
        if (root == null!)
            return;
        
        InorderTraversal(root.left, list);
        list.Add(root.val);
        InorderTraversal(root.right, list);
    }
}
