// ReSharper disable InconsistentNaming

using System.Text;
using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.ConstructStringFromBinaryTree01;

public class Solution
{
    public string Tree2str(TreeNode root)
    {
        if (root == null)
            return "";

        var result = new StringBuilder();
        result.Append(root.val);

        if (root.left != null || root.right != null)
            result.Append("(" + Tree2str(root.left!) + ")");

        if (root.right != null)
            result.Append("(" + Tree2str(root.right) + ")");

        return result.ToString();
    }
}
