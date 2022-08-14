namespace LeetCodeCSharpApp.NodeWithHighestEdgeScore01;

public class Solution
{
    public int EdgeScore(int[] edges)
    {
        var scores = new long[edges.Length];

        for (var i = 0; i < edges.Length; i++)
            scores[edges[i]] += i;

        return scores.ToList().IndexOf(scores.Max());
    }
}
