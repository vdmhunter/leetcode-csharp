// ReSharper disable InconsistentNaming
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable FieldCanBeMadeReadOnly.Global

namespace LeetCodeCSharpApp.Common;

public class TreeNode
{
    public int val;

    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val = 0, TreeNode left = null!, TreeNode right = null!)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}
