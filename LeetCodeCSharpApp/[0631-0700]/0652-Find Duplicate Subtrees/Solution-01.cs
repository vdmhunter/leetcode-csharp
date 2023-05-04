using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.FindDuplicateSubtrees01;

public class Solution
{
    public IList<TreeNode> FindDuplicateSubtrees(TreeNode root)
    {
        var result = new List<TreeNode>();
        var tripletToId = new Dictionary<string, int>();
        var counts = new Dictionary<int, int>();
        Traverse(root, tripletToId, counts, result);

        return result;
    }

    private static int Traverse(TreeNode node, Dictionary<string, int> tripletToId, Dictionary<int, int> counts,
        List<TreeNode> result)
    {
        if (node == null)
            return 0;

        var triplet = string.Format("{0},{1},{2}", Traverse(node.left, tripletToId, counts, result), node.val,
            Traverse(node.right, tripletToId, counts, result));

        tripletToId.TryAdd(triplet, tripletToId.Count + 1);

        var id = tripletToId[triplet];

        if (counts.ContainsKey(id))
            counts[id]++;
        else
            counts.Add(id, 1);

        if (counts[id] == 2)
            result.Add(node);

        return id;
    }
}
