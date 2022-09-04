using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.VerticalOrderTraversalOfABinaryTree01;

public class Solution
{
    public IList<IList<int>> VerticalTraversal(TreeNode root)
    {
        var sortedList = new SortedList<int, List<(int, int)>>();
        var result = new List<IList<int>>();
        
        if (root == null) 
            return result;
        
        AddElement(sortedList, root, 0, 0);

        result.AddRange(sortedList.Select(list => list.Value
            .OrderBy(x => x.Item2)
            .ThenBy(x => x.Item1)
            .Select(x => x.Item1)
            .ToList()));

        return result;
    }

    private void AddElement(SortedList<int, List<(int, int)>> sortedList, TreeNode node, int order, int level)
    {
        if (node == null)
            return;

        if (!sortedList.ContainsKey(order))
            sortedList.Add(order, new List<(int, int)> { (node.val, level) });
        else
            sortedList[order].Add((node.val, level));

        AddElement(sortedList, node.left, order - 1, level + 1);
        AddElement(sortedList, node.right, order + 1, level + 1);
    }
}
