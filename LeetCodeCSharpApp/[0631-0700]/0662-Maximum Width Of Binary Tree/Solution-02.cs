using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.MaximumWidthOfBinaryTree02;

public class Solution
{
    public int WidthOfBinaryTree(TreeNode root)
    {
        return Dfs(root, 0, 1, new List<(int Start, int End)>());
    }

    private static int Dfs(TreeNode root, int level, int order, List<(int Start, int End)> vec)
    {
        if (root == null)
            return 0;

        if (vec.Count == level)
            vec.Add((order, order));
        else
            vec[level] = (vec[level].Start, order);

        return new[]
        {
            vec[level].End - vec[level].Start + 1,
            Dfs(root.left, level + 1, 2 * order, vec),
            Dfs(root.right, level + 1, 2 * order + 1, vec)
        }.Max();
    }
}
