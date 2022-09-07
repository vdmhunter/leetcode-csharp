using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.ConstructStringFromBinaryTree01;

public class Solution
{
    // ReSharper disable once InconsistentNaming
    public string Tree2str(TreeNode root)
    {
        // ReSharper disable once ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
        if (root == null)
            return "";

        var result = root.val + "";

        var left = Tree2str(root.left);
        var right = Tree2str(root.right);

        if (left == "" && right == "")
            return result;

        if (left == "")
            return result + "()" + "(" + right + ")";

        if (right == "")
            return result + "(" + left + ")";

        return result + "(" + left + ")" + "(" + right + ")";
    }
}
