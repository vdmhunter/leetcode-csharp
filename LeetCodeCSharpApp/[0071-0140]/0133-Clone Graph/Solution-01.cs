using LeetCodeCSharpApp.Common.CloneGraph;

namespace LeetCodeCSharpApp.CloneGraph01;

public class Solution
{
    public Node CloneGraph(Node node)
    {
        if (node == null)
            return null!;

        var q = new Queue<Node>();
        q.Enqueue(node);
        var clones = new Dictionary<int, Node>
        {
            {
                node.val,
                new Node(node.val, new List<Node>())
            }
        };

        while (q.Count > 0)
        {
            var cur = q.Dequeue();
            var curClone = clones[cur.val];

            foreach (var n in cur.neighbors)
            {
                if (!clones.ContainsKey(n.val))
                {
                    clones.Add(n.val, new Node(n.val, new List<Node>()));
                    q.Enqueue(n);
                }

                curClone.neighbors.Add(clones[n.val]);
            }
        }

        return clones[node.val];
    }
}
