using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.MaximumProductOfSplittedBinaryTree01;

public class Solution
{
    private const int M = 1000000007;
    private long _result;
    private long _total;
    private long _sub;

    public int MaxProduct(TreeNode root)
    {
        _total = S(root);
        S(root);

        return (int)(_result % M);
    }

    private long S(TreeNode root)
    {
        if (root == null)
            return 0;

        _sub = root.val + S(root.left) + S(root.right);
        _result = Math.Max(_result, _sub * (_total - _sub));

        return _sub;
    }
}
