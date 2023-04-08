using LeetCodeCSharpApp.Common.CloneGraph;

namespace LeetCodeCSharpApp.CloneGraph02;

public class Solution
{
    public Node CloneGraph(Node node)
    {
        if (node == null)
            return null!;

        var seen = new Dictionary<int, Node>();

        return Dfs(seen, node);
    }

    private Node Dfs(Dictionary<int, Node> seen, Node node)
    {
        var curr = new Node(node.val);
        seen.Add(curr.val, curr);

        foreach (var n in node.neighbors)
        {
            if (!seen.ContainsKey(n.val))
                Dfs(seen, n);

            curr.neighbors.Add(seen[n.val]);
        }

        return curr;
    }
}
