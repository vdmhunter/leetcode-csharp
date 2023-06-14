using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.MinimumAbsoluteDifferenceInBST01;

public class Solution
{
    private int _minDif = int.MaxValue;
    private int _val = -1;

    public int GetMinimumDifference(TreeNode root)
    {
        if (root.left != null)
            GetMinimumDifference(root.left);

        if (_val >= 0)
            _minDif = Math.Min(_minDif, root.val - _val);

        _val = root.val;

        if (root.right != null)
            GetMinimumDifference(root.right);

        return _minDif;
    }
}
