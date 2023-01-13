namespace LeetCodeCSharpApp.LongestPathWithDifferentAdjacentCharacters01;

public class Solution
{
    private int _result;

    public int LongestPath(int[] parent, string s)
    {
        _result = 0;

        var children = new List<int>[parent.Length];

        for (var i = 0; i < parent.Length; i++)
            children[i] = new List<int>();

        for (var i = 1; i < parent.Length; i++)
            children[parent[i]].Add(i);

        Dfs(children, s, 0);

        return _result;
    }

    private int Dfs(List<int>[] children, string s, int i)
    {
        var queue = new PriorityQueue<int, int>();

        foreach (var j in children[i])
        {
            var cur = Dfs(children, s, j);

            if (s[j] != s[i])
                queue.Enqueue(cur, -cur);
        }

        var big1 = queue.Count == 0 ? 0 : queue.Dequeue();
        var big2 = queue.Count == 0 ? 0 : queue.Dequeue();
        _result = Math.Max(_result, big1 + big2 + 1);

        return big1 + 1;
    }
}
