namespace LeetCodeCSharpApp.ErectTheFence01;

public class Solution
{
    public int[][] OuterTrees(int[][] trees)
    {
        Array.Sort(trees, (t1, t2) =>
        {
            if (t1[0] != t2[0])
                return t1[0] - t2[0];

            return t1[1] - t2[1];
        });

        List<int[]> lower = new();
        List<int[]> upper = new();

        foreach (var tree in trees)
        {
            while (lower.Count >= 2 && Cross(lower[^2], lower[^1], tree) < 0)
                lower.RemoveAt(lower.Count - 1);

            lower.Add(tree);
        }

        for (var i = trees.Length - 1; i >= 0; i--)
        {
            while (upper.Count >= 2 && Cross(upper[^2], upper[^1], trees[i]) < 0)
                upper.RemoveAt(upper.Count - 1);
            
            upper.Add(trees[i]);
        }

        return new HashSet<int[]>(lower.Concat(upper)).ToArray();
    }

    private static int Cross(int[] o, int[] a, int[] b)
    {
        return (a[0] - o[0]) * (b[1] - o[1]) - (a[1] - o[1]) * (b[0] - o[0]);
    }
}
