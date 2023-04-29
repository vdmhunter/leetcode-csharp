using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.BinaryTreePreorderTraversal01;

public class Solution
{
    private readonly List<int> _result = new();

    public IList<int> PreorderTraversal(TreeNode root)
    {
        Dfs(root);

        return _result;
    }

    private void Dfs(TreeNode node)
    {
        if (node == null)
            return;

        _result.Add(node.val);

        Dfs(node.left);
        Dfs(node.right);
    }
}
