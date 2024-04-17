using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.SmallestStringStartingFromLeaf01;

public class Solution
{
    public string SmallestFromLeaf(TreeNode root, string s = "")
    {
        if (root == null!)
            return s;

        var ch = (char)('a' + root.val);
        s = ch + s;

        if (root.left == null! && root.right == null!)
            return s;

        var leftSmallest = root.left != null ? SmallestFromLeaf(root.left, s) : "|";
        var rightSmallest = root.right != null! ? SmallestFromLeaf(root.right, s) : "|";

        if (leftSmallest == "|")
            return rightSmallest;

        if (rightSmallest == "|")
            return leftSmallest;

        return string.Compare(leftSmallest, rightSmallest, StringComparison.Ordinal) < 0
            ? leftSmallest
            : rightSmallest;
    }
}