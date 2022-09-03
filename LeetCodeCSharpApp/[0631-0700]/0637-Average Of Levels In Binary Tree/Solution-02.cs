using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.AverageOfLevelsInBinaryTree02;

/// <summary>
/// DFS
/// </summary>
public class Solution
{
    private IList<int>? _levelCount;
    private IList<long>? _levelSum;

    public IList<double> AverageOfLevels(TreeNode root)
    {
        _levelCount = new List<int>();
        _levelSum = new List<long>();

        Dfs(root, 1);

        return _levelCount.Select((c, i) => _levelSum[i] / (double)c).ToList();
    }

    private void Dfs(TreeNode root, int level)
    {
        if (root == null)
            return;

        if (_levelCount!.Count < level)
        {
            _levelCount.Add(1);
            _levelSum!.Add(root.val);
        }
        else
        {
            _levelCount[level - 1]++;
            _levelSum![level - 1] += root.val;
        }

        Dfs(root.left, level + 1);
        Dfs(root.right, level + 1);
    }
}
