using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.BinaryTreePreorderTraversal02;

public class Solution
{
    public IList<int> PreorderTraversal(TreeNode root)
    {
        var result = new List<int>();
        var stack = new Stack<TreeNode>();
        stack.Push(root);

        while (stack.Count != 0)
        {
            var currNode = stack.Peek();
            stack.Pop();

            if (currNode == null)
                continue;

            result.Add(currNode.val);
            stack.Push(currNode.right);
            stack.Push(currNode.left);
        }

        return result;
    }
}
