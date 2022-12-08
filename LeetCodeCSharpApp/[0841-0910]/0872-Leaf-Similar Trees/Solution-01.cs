using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.LeafSimilarTrees01;

public class Solution
{
    public bool LeafSimilar(TreeNode root1, TreeNode root2)
    {
        return GetLeafValues(root1).SequenceEqual(GetLeafValues(root2));
    }

    private static IEnumerable<int> GetLeafValues(TreeNode node)
    {
        /* 
         * This is a pretty standard tree traversal,
         * the only thing to note is that we emit
         * a leaf element once it's found and we do not
         * accumulate the result in a list. That
         * produces lazy and (possibly) infinite stream
         * of data.
         */
        Stack<TreeNode> stack = new();

        stack.Push(node);

        while (stack.Count > 0)
        {
            var c = stack.Pop();

            if (c.left == null && c.right == null)
                yield return c.val;

            if (c.right != null)
                stack.Push(c.right);

            if (c.left != null)
                stack.Push(c.left);
        }
    }
}
