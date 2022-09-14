using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.PseudoPalindromicPathsInABinaryTree01;

public class Solution
{
    public int PseudoPalindromicPaths(TreeNode root, int count = 0)
    {
        if (root == null)
            return 0;

        count ^= 1 << (root.val - 1);
        var res = PseudoPalindromicPaths(root.left, count) + PseudoPalindromicPaths(root.right, count);

        if (root.left == root.right && (count & (count - 1)) == 0)
            res++;

        return res;
    }
}
