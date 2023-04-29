using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.TwoSumIVInputIsABst01;

public class Solution
{
    private readonly HashSet<int> _values = new();

    public bool FindTarget(TreeNode root, int k)
    {
        if (root == null)
            return false;

        if (_values.Contains(k - root.val))
            return true;

        _values.Add(root.val);

        return FindTarget(root.left, k) || FindTarget(root.right, k);
    }
}
