using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.FindModeInBinarySearchTree01;

public class Solution
{
    private int? _currentVal;
    private int _currentCount;
    private int _maxCount;
    private readonly List<int> _modes = new();

    public int[] FindMode(TreeNode root)
    {
        InorderTraversal(root);

        return _modes.ToArray();
    }

    private void InorderTraversal(TreeNode node)
    {
        if (node == null!)
            return;

        InorderTraversal(node.left);

        _currentCount = node.val == _currentVal
            ? _currentCount + 1
            : 1;

        if (_currentCount == _maxCount)
        {
            _modes.Add(node.val);
        }
        else if (_currentCount > _maxCount)
        {
            _maxCount = _currentCount;
            _modes.Clear();
            _modes.Add(node.val);
        }

        _currentVal = node.val;

        InorderTraversal(node.right);
    }
}
