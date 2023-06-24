using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.MaximumLevelSumOfABinaryTree02;

public class Solution
{
    private readonly List<int> _sums = new();

    public int MaxLevelSum(TreeNode root)
    {
        Dfs(root, 1);

        return _sums.IndexOf(_sums.Max()) + 1;
    }

    private void Dfs(TreeNode r, int lvl)
    {
        if (r == null)
            return;

        if (_sums.Count < lvl)
            _sums.Add(0);

        _sums[lvl - 1] += r.val;

        Dfs(r.left, lvl + 1);
        Dfs(r.right, lvl + 1);
    }
}
