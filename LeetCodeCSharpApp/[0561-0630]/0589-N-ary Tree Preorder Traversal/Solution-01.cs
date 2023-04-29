using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.NaryTreePreorderTraversal01;

/// <summary>
/// Iterative Solution
/// </summary>
public class Solution
{
    public IList<int> Preorder(Node root)
    {
        var list = new List<int>();

        if (root == null)
            return list;

        var stack = new Stack<Node>();
        stack.Push(root);

        while (!stack.Any())
        {
            root = stack.Pop();

            list.Add(root.val);

            for (var i = root.children.Count - 1; i >= 0; i--)
                stack.Push(root.children[i]);
        }

        return list;
    }
}
