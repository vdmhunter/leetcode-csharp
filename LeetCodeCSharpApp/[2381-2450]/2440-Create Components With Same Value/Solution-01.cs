namespace LeetCodeCSharpApp.CreateComponentsWithSameValue01;

public class Solution
{
    public int ComponentValue(int[] nums, int[][] edges)
    {
        var n = nums.Length;
        var tree = new List<int>[n];

        for (var i = 0; i < n; i++)
            tree[i] = new List<int>();

        foreach (var edge in edges)
        {
            tree[edge[0]].Add(edge[1]);
            tree[edge[1]].Add(edge[0]);
        }

        int deletedEdges = 0, root = 0;
        var sum = nums.Sum();

        for (var i = 1; i <= sum; i++)
        {
            if (sum % i != 0)
                continue;

            if (Fun(root, -1, i) == 0)
                deletedEdges = Math.Max(deletedEdges, sum / i - 1);
        }

        return deletedEdges;

        int Fun(int subRoot, int parent, int reqSum)
        {
            var resultSum = nums[subRoot];
            
            foreach (var child in tree[subRoot])
            {
                if (child == parent)
                    continue;
                
                resultSum += Fun(child, subRoot, reqSum);
            }

            return resultSum == reqSum ? 0 : resultSum;
        }
    }
}
