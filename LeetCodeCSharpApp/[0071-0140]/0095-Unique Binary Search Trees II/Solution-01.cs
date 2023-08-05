using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.UniqueBinarySearchTreesII01;

public class Solution
{
    public IList<TreeNode> GenerateTrees(int n)
    {
        return Trees(1, n).ToArray();
    }

    private static List<TreeNode> Trees(int first, int last)
    {
        var result = new List<TreeNode>();

        for (var root = first; root <= last; root++)
            result.AddRange(
                from left in Trees(first, root - 1)
                from right in Trees(root + 1, last)
                select Node(root, left, right));

        return result.Count > 0
            ? result
            : new List<TreeNode> { null! };
    }

    private static TreeNode Node(int val, TreeNode left, TreeNode right)
    {
        var node = new TreeNode(val)
        {
            left = left,
            right = right
        };

        return node;
    }
}
