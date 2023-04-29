using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.NaryTreeLevelOrderTraversal01;

public class Solution
{
    public IList<IList<int>> LevelOrder(Node root)
    {
        IList<IList<int>> result = new List<IList<int>>();

        Traverse(root, result);

        return result;
    }

    private static void Traverse(Node node, IList<IList<int>> res, int level = 0)
    {
        if (node == null)
            return;

        if (res.Count <= level)
            res.Add(new List<int>());

        res[level].Add(node.val);

        foreach (var n in node.children)
            Traverse(n, res, level + 1);
    }
}
