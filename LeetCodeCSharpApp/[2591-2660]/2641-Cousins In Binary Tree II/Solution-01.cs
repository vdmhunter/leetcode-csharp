using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.CousinsInBinaryTreeII01;

public class Solution
{
    private readonly List<int> _levelSum = new();

    public TreeNode ReplaceValueInTree(TreeNode root)
    {
        LevelSum(root);
        UpdateSum(root, 0);

        return root;
    }

    private void LevelSum(TreeNode n, int d = 0)
    {
        if (n == null)
            return;

        if (_levelSum.Count <= d)
            _levelSum.Add(0);

        _levelSum[d] += n.val;

        LevelSum(n.left, d + 1);
        LevelSum(n.right, d + 1);
    }

    private void UpdateSum(TreeNode n, int sib, int d = 0)
    {
        if (n == null)
            return;

        var lv = n.left?.val ?? 0;
        var rv = n.right?.val ?? 0;

        n.val = _levelSum[d] - n.val - sib;

        UpdateSum(n.left!, rv, d + 1);
        UpdateSum(n.right!, lv, d + 1);
    }
}
