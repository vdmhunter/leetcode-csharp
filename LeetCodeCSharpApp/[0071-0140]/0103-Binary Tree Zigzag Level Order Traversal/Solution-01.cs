using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.BinaryTreeZigzagLevelOrderTraversal01;

public class Solution
{
    private readonly Dictionary<int, List<int>> _dict = new();

    public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
    {
        var result = new List<IList<int>>();
        Dfs(root, 0);
        var bol = true;

        foreach (var item in _dict.Values)
        {
            result.Add(bol ? item : item.Select(x => x).Reverse().ToList());
            bol = !bol;
        }

        return result;
    }

    private void Dfs(TreeNode root, int i)
    {
        if (root == null)
            return;

        if (!_dict.ContainsKey(i))
            _dict.Add(i, new List<int>());

        _dict[i].Add(root.val);
        Dfs(root.left, i + 1);
        Dfs(root.right, i + 1);
    }
}
