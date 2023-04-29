using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.AmountOfTimeForBinaryTreeToBeInfected01;

/// <summary>
/// BFS
/// </summary>
public class Solution
{
    private readonly Dictionary<int, List<int>> _adjacencyDictionary = new();

    public int AmountOfTime(TreeNode root, int start)
    {
        //create graph of given tree
        CreateGraph(root);

        //start bfs
        var q = new Queue<int>();
        q.Enqueue(start);
        var seen = new HashSet<int> { start };
        var time = 0;

        for (; q.Count > 0; time++)
        {
            var n = q.Count;

            while (n-- != 0)
            {
                var node = q.Dequeue();

                if (!_adjacencyDictionary.ContainsKey(node))
                    continue;

                foreach (var i in _adjacencyDictionary[node].Where(item => !seen.Contains(item)))
                {
                    q.Enqueue(i);
                    seen.Add(i);
                }
            }
        }

        return time - 1;
    }

    //create undirected graph for every parent-child  -> BFS
    private void CreateGraph(TreeNode root)
    {
        var q = new Queue<(TreeNode, int)>();
        q.Enqueue((root, -1));

        while (q.Count != 0)
        {
            var (node, parent) = q.Dequeue();

            if (parent != -1)
            {
                FillAdjacencyDictionary(parent, node.val);
                FillAdjacencyDictionary(node.val, parent);
            }

            if (node.left != null)
                q.Enqueue((node.left, node.val));

            if (node.right != null)
                q.Enqueue((node.right, node.val));
        }
    }

    private void FillAdjacencyDictionary(int key, int val)
    {
        if (_adjacencyDictionary.ContainsKey(key))
            _adjacencyDictionary[key].Add(val);
        else
            _adjacencyDictionary.Add(key, new List<int> { val });
    }
}
