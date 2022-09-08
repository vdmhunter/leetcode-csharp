using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.BinaryTreeInorderTraversal01;

public class Solution
{
    public IList<int> InorderTraversal(TreeNode root)
    {
        var result = new List<int>();

        var stack = new Stack<TreeNode>();
        var cur = root;

        while (cur != null! || stack.Count != 0)
        {
            while (cur != null)
            {
                stack.Push(cur);
                cur = cur.left;
            }

            cur = stack.Pop();
            result.Add(cur.val);
            cur = cur.right;
        }

        return result;
    }
}
