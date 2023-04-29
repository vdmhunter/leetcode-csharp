using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.PathSum02;

public class Solution
{
    public bool HasPathSum(TreeNode root, int targetSum)
    {
        if (root == null!)
            return false;

        var stack = new Stack<TreeNode>();
        stack.Push(root);

        while (stack.Count != 0)
        {
            var pv = stack.Pop();

            if (pv.val == targetSum && pv.left == null! && pv.right == null!)
                return true;

            if (pv.left != null)
            {
                pv.left.val += pv.val;
                stack.Push(pv.left);
            }

            if (pv.right != null!)
            {
                pv.right.val += pv.val;
                stack.Push(pv.right);
            }
        }

        return false;
    }
}
